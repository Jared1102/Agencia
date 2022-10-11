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
        private bool CerrarSesion = false;
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
                if (!FrmSesion.usuario.PermisosHerramienta.Leer)
                {
                    tsbHerramientas.Visible = false;
                }
                else
                {
                    tsbHerramientas.Visible = true;
                }
            }
            
        }
        #endregion

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

        private void tsbHerramientas_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmHerramientas());
        }

        private void tsbCerrarSesion_Click(object sender, EventArgs e)
        {
            CerrarSesion = true;
            this.Close();
        }

        private void FrmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            hiloUsuario.Abort();
            if (!CerrarSesion)
            {
                Application.Exit();
            }
        }
    }
}
