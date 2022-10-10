using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionAgencia
{
    public partial class FrmMenu : Form
    {
        private Form activeForm=null;
        private Thread hiloUsuario;
        public FrmMenu()
        {
            InitializeComponent();
            hiloUsuario = new Thread(habilitarProductos);
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

        private void habilitarProductos()
        {
            while (true)
            {
                if (!FrmSesion.usuario.PermisosProducto.Leer)
                {
                    tsbProductos.Visible = false;
                }
                else
                {
                    tsbProductos.Visible = true;
                }
            }
            
        }
        #endregion
        private void FrmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            hiloUsuario.Abort();
            Application.Exit();
        }

        private void tsbProductos_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmProductos());
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            hiloUsuario.Start();
        }

        private void tsbUsuario_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmUsuario());
        }
    }
}
