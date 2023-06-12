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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void ribbonButton2_Click(object sender, EventArgs e)
        {
            new FrmArticulo().ShowDialog();
        }

        private void ribbonButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ribbonButton7_Click(object sender, EventArgs e)
        {
            new FrmVendedor().ShowDialog();
        }

        private void ribbonButton8_Click(object sender, EventArgs e)
        {
            new FrmCliente().ShowDialog();
        }
    }
}
