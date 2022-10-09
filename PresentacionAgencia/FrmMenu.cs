using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionAgencia
{
    public partial class FrmMenu : Form
    {
        private Form activeForm=null;
        public FrmMenu()
        {
            InitializeComponent();
        }
        #region Componente

        public void openChildForm(Form formulario)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = formulario;
            formulario.TopLevel = true;
            formulario.MdiParent = this;
            formulario.Show();
        }

        #endregion
        private void FrmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tsbProductos_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmProductos());
        }
    }
}
