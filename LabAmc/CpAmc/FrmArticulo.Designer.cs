namespace CpAmc
{
    partial class FrmArticulo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmArticulo));
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtParametro = new System.Windows.Forms.TextBox();
            this.lblParametro = new System.Windows.Forms.Label();
            this.gbxLista = new System.Windows.Forms.GroupBox();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gbxDatos = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblPrecioVenta = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.cbxUnidad = new System.Windows.Forms.ComboBox();
            this.lblUnidadMedida = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.erpCodigo = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpDescripcion = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpUnidad = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpExistenciaMinima = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpExistenciaMaxima = new System.Windows.Forms.ErrorProvider(this.components);
            this.nudPrecio = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtExistenciaMaxima = new System.Windows.Forms.TextBox();
            this.txtExistenciaMinima = new System.Windows.Forms.TextBox();
            this.erpPrecio = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlBotones.SuspendLayout();
            this.gbxLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.gbxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpCodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDescripcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpUnidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpExistenciaMinima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpExistenciaMaxima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpPrecio)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBotones
            // 
            this.pnlBotones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBotones.Controls.Add(this.btnCerrar);
            this.pnlBotones.Controls.Add(this.btnEliminar);
            this.pnlBotones.Controls.Add(this.btnEditar);
            this.pnlBotones.Controls.Add(this.btnNuevo);
            this.pnlBotones.Location = new System.Drawing.Point(177, 324);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(626, 60);
            this.pnlBotones.TabIndex = 11;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(401, 6);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(90, 48);
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(298, 6);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(97, 48);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(208, 6);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(84, 48);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(103, 6);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(99, 48);
            this.btnNuevo.TabIndex = 6;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(864, 51);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(93, 48);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = " Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtParametro
            // 
            this.txtParametro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtParametro.Location = new System.Drawing.Point(364, 64);
            this.txtParametro.Name = "txtParametro";
            this.txtParametro.Size = new System.Drawing.Size(495, 20);
            this.txtParametro.TabIndex = 9;
            // 
            // lblParametro
            // 
            this.lblParametro.AutoSize = true;
            this.lblParametro.Location = new System.Drawing.Point(16, 67);
            this.lblParametro.Name = "lblParametro";
            this.lblParametro.Size = new System.Drawing.Size(205, 13);
            this.lblParametro.TabIndex = 8;
            this.lblParametro.Text = "Buscar por Código, Descripción o Unidad ";
            // 
            // gbxLista
            // 
            this.gbxLista.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxLista.Controls.Add(this.dgvLista);
            this.gbxLista.Location = new System.Drawing.Point(10, 108);
            this.gbxLista.Name = "gbxLista";
            this.gbxLista.Size = new System.Drawing.Size(948, 209);
            this.gbxLista.TabIndex = 7;
            this.gbxLista.TabStop = false;
            this.gbxLista.Text = "Lista de Articulos";
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(10, 27);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.RowHeadersWidth = 51;
            this.dgvLista.RowTemplate.Height = 24;
            this.dgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLista.Size = new System.Drawing.Size(932, 162);
            this.dgvLista.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(13, 9);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(935, 43);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Articulos";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbxDatos
            // 
            this.gbxDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxDatos.Controls.Add(this.txtExistenciaMinima);
            this.gbxDatos.Controls.Add(this.txtExistenciaMaxima);
            this.gbxDatos.Controls.Add(this.label1);
            this.gbxDatos.Controls.Add(this.nudPrecio);
            this.gbxDatos.Controls.Add(this.btnCancelar);
            this.gbxDatos.Controls.Add(this.btnGuardar);
            this.gbxDatos.Controls.Add(this.lblPrecioVenta);
            this.gbxDatos.Controls.Add(this.lblSaldo);
            this.gbxDatos.Controls.Add(this.cbxUnidad);
            this.gbxDatos.Controls.Add(this.lblUnidadMedida);
            this.gbxDatos.Controls.Add(this.txtDescripcion);
            this.gbxDatos.Controls.Add(this.lblDescripcion);
            this.gbxDatos.Controls.Add(this.txtCodigo);
            this.gbxDatos.Controls.Add(this.lblCodigo);
            this.gbxDatos.Location = new System.Drawing.Point(19, 391);
            this.gbxDatos.Name = "gbxDatos";
            this.gbxDatos.Size = new System.Drawing.Size(948, 156);
            this.gbxDatos.TabIndex = 12;
            this.gbxDatos.TabStop = false;
            this.gbxDatos.Text = "Datos del Producto";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(753, 97);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(104, 48);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(645, 97);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(102, 48);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblPrecioVenta
            // 
            this.lblPrecioVenta.AutoSize = true;
            this.lblPrecioVenta.Location = new System.Drawing.Point(495, 34);
            this.lblPrecioVenta.Name = "lblPrecioVenta";
            this.lblPrecioVenta.Size = new System.Drawing.Size(94, 13);
            this.lblPrecioVenta.TabIndex = 9;
            this.lblPrecioVenta.Text = "Existencia Maxima";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(495, 65);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(94, 13);
            this.lblSaldo.TabIndex = 7;
            this.lblSaldo.Text = "Existencia Minima:";
            // 
            // cbxUnidad
            // 
            this.cbxUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUnidad.FormattingEnabled = true;
            this.cbxUnidad.Items.AddRange(new object[] {
            "",
            "Unidad",
            "Kilo",
            "Libra",
            "Gramo"});
            this.cbxUnidad.Location = new System.Drawing.Point(158, 129);
            this.cbxUnidad.Name = "cbxUnidad";
            this.cbxUnidad.Size = new System.Drawing.Size(251, 21);
            this.cbxUnidad.TabIndex = 5;
            // 
            // lblUnidadMedida
            // 
            this.lblUnidadMedida.AutoSize = true;
            this.lblUnidadMedida.Location = new System.Drawing.Point(20, 132);
            this.lblUnidadMedida.Name = "lblUnidadMedida";
            this.lblUnidadMedida.Size = new System.Drawing.Size(44, 13);
            this.lblUnidadMedida.TabIndex = 4;
            this.lblUnidadMedida.Text = "Unidad:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(158, 62);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(251, 20);
            this.txtDescripcion.TabIndex = 3;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(20, 65);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(158, 28);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(251, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(20, 31);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // erpCodigo
            // 
            this.erpCodigo.ContainerControl = this;
            // 
            // erpDescripcion
            // 
            this.erpDescripcion.ContainerControl = this;
            // 
            // erpUnidad
            // 
            this.erpUnidad.ContainerControl = this;
            // 
            // erpExistenciaMinima
            // 
            this.erpExistenciaMinima.ContainerControl = this;
            // 
            // erpExistenciaMaxima
            // 
            this.erpExistenciaMaxima.ContainerControl = this;
            // 
            // nudPrecio
            // 
            this.nudPrecio.Location = new System.Drawing.Point(158, 97);
            this.nudPrecio.Name = "nudPrecio";
            this.nudPrecio.Size = new System.Drawing.Size(251, 20);
            this.nudPrecio.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Precio:";
            // 
            // txtExistenciaMaxima
            // 
            this.txtExistenciaMaxima.Location = new System.Drawing.Point(606, 31);
            this.txtExistenciaMaxima.Name = "txtExistenciaMaxima";
            this.txtExistenciaMaxima.Size = new System.Drawing.Size(251, 20);
            this.txtExistenciaMaxima.TabIndex = 14;
            // 
            // txtExistenciaMinima
            // 
            this.txtExistenciaMinima.Location = new System.Drawing.Point(606, 62);
            this.txtExistenciaMinima.Name = "txtExistenciaMinima";
            this.txtExistenciaMinima.Size = new System.Drawing.Size(251, 20);
            this.txtExistenciaMinima.TabIndex = 15;
            // 
            // erpPrecio
            // 
            this.erpPrecio.ContainerControl = this;
            // 
            // FrmArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 559);
            this.Controls.Add(this.gbxDatos);
            this.Controls.Add(this.pnlBotones);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtParametro);
            this.Controls.Add(this.lblParametro);
            this.Controls.Add(this.gbxLista);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmArticulo";
            this.Text = "FrmArticulo";
            this.pnlBotones.ResumeLayout(false);
            this.gbxLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.gbxDatos.ResumeLayout(false);
            this.gbxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpCodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDescripcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpUnidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpExistenciaMinima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpExistenciaMaxima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpPrecio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtParametro;
        private System.Windows.Forms.Label lblParametro;
        private System.Windows.Forms.GroupBox gbxLista;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gbxDatos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblPrecioVenta;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.ComboBox cbxUnidad;
        private System.Windows.Forms.Label lblUnidadMedida;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.ErrorProvider erpCodigo;
        private System.Windows.Forms.ErrorProvider erpDescripcion;
        private System.Windows.Forms.ErrorProvider erpUnidad;
        private System.Windows.Forms.ErrorProvider erpExistenciaMinima;
        private System.Windows.Forms.ErrorProvider erpExistenciaMaxima;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudPrecio;
        private System.Windows.Forms.TextBox txtExistenciaMinima;
        private System.Windows.Forms.TextBox txtExistenciaMaxima;
        private System.Windows.Forms.ErrorProvider erpPrecio;
    }
}