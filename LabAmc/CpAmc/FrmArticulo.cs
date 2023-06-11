using CadAmc;
using ClnAmc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CpAmc
{
    public partial class FrmArticulo : Form
    {
        bool esNuevo = false;
        public FrmArticulo()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listar();
        }
        private void listar()
        {
            var articulos = ArticuloCln.listarPa(txtParametro.Text.Trim());
            dgvLista.DataSource = articulos;
            dgvLista.Columns["id"].Visible = false;
            dgvLista.Columns["codigo"].HeaderText = "Código";
            dgvLista.Columns["descripcion"].HeaderText = "Descripción";
            dgvLista.Columns["precio"].HeaderText = "precio";
            dgvLista.Columns["unidad"].HeaderText = "unidad";
            dgvLista.Columns["existenciaMaxima"].HeaderText = "Existencia Maxima";
            dgvLista.Columns["existenciaMinima"].HeaderText = "Existencia Minima";
            dgvLista.Columns["usuarioRegistro"].HeaderText = "Usuario Registro";
            dgvLista.Columns["fechaRegistro"].HeaderText = "Fecha Registro";
            btnEditar.Enabled = articulos.Count > 0;
            btnEliminar.Enabled = articulos.Count > 0;
            if (articulos.Count > 0) dgvLista.Rows[0].Cells["codigo"].Selected = true;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            Size = new Size(981, 598);
            txtCodigo.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            Size = new Size(981, 598);

            int index = dgvLista.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
            var articulo = ArticuloCln.get(id);
            txtCodigo.Text = articulo.codigo;
            txtDescripcion.Text = articulo.descripcion;
            nudPrecio.Value = articulo.precio;
            cbxUnidad.Text = articulo.unidad;
            txtExistenciaMaxima.Text = Convert.ToString(articulo.existenciaMaxima);
            txtExistenciaMinima.Text = Convert.ToString(articulo.existenciaMinima);
        }

        private void limpiar()
        {
            txtCodigo.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            nudPrecio.Value = 0;
            cbxUnidad.SelectedIndex = -1;
            txtExistenciaMaxima.Text = string.Empty;
            txtExistenciaMinima.Text = string.Empty;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int index = dgvLista.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
            string codigo = dgvLista.Rows[index].Cells["codigo"].Value.ToString();
            DialogResult dialog = MessageBox.Show($"¿Está seguro que desea dar de baja " +
                $"el articulo {codigo}?", "::: Minerva - Mensaje :::",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.OK)
            {
                ArticuloCln.eliminar(id, "Alvaro");
                listar();
                MessageBox.Show($"Articulo dado de baja correctamente", "::: LabAmc - Mensaje :::",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool validar()
        {
            bool esValido = true;
            erpCodigo.SetError(txtCodigo, "");
            erpDescripcion.SetError(txtDescripcion, "");
            erpPrecio.SetError(nudPrecio, "");
            erpUnidad.SetError(cbxUnidad, "");
            erpExistenciaMaxima.SetError(txtExistenciaMaxima, "");
            erpExistenciaMinima.SetError(txtExistenciaMinima, "");

            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                erpCodigo.SetError(txtCodigo, "El campo Código es obligatorio");
                esValido = false;
            }
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                erpDescripcion.SetError(txtDescripcion, "El campo Descripción es obligatorio");
                esValido = false;
            }

            if (string.IsNullOrEmpty(nudPrecio.Text))
            {
                erpUnidad.SetError(nudPrecio, "El campo Precio es obligatorio");
                esValido = false;
            }

            if (nudPrecio.Value < 0)
            {
                erpExistenciaMinima.SetError(nudPrecio, "El campo Precio debe ser mayor a 0");
                esValido = false;
            }

            if (string.IsNullOrEmpty(cbxUnidad.Text))
            {
                erpUnidad.SetError(cbxUnidad, "El campo Unidad  es obligatorio");
                esValido = false;
            }

            if (string.IsNullOrEmpty(txtExistenciaMaxima.Text))
            {
                erpExistenciaMinima.SetError(txtExistenciaMaxima, "El campo Existencia Maxima es obligatorio");
                esValido = false;
            }

            if (string.IsNullOrEmpty(txtExistenciaMinima.Text))
            {
                erpExistenciaMinima.SetError(txtExistenciaMinima, "El campo Existencia Minima es obligatorio");
                esValido = false;
            }

            return esValido;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                var articulo = new Articulo();
                articulo.codigo = txtCodigo.Text.Trim();
                articulo.descripcion = txtDescripcion.Text.Trim();
                articulo.precio = nudPrecio.Value;
                articulo.unidad = cbxUnidad.Text;
                articulo.existenciaMaxima = Convert.ToInt32( txtExistenciaMinima.Text.Trim());
                articulo.existenciaMinima = Convert.ToInt32(txtExistenciaMaxima.Text.Trim());

                //articulo.usuarioRegistro = Util.usuario.usuario;

                if (esNuevo)
                {
                    articulo.fechaRegistro = DateTime.Now;
                    articulo.registroActivo = true;
                    ArticuloCln.insertar(articulo);
                }
                else
                {
                    int index = dgvLista.CurrentCell.RowIndex;
                    articulo.id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
                    ArticuloCln.actualizar(articulo);
                }
                listar();
                btnCancelar.PerformClick();
                MessageBox.Show("Articulo guardado correctamente", "::: Minerva - Mensaje :::",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Size = new Size(981, 439);
            limpiar();
        }
    }
}
