using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManejadorAgencia;
using EntidadesAgencia;

namespace PresentacionAgencia
{
    public partial class FrmSesion : Form
    {
        private ManejadorUsuario _manejadorUsuario;
        public static Usuario usuario=null;
        public FrmSesion()
        {
            InitializeComponent();
            _manejadorUsuario = new ManejadorUsuario();
        }

        #region Componentes

        private void Cerrar()
        {
            this.Close();
        }

        private void Acceder()
        {
            if (usuario != null)
            {
                FrmMenu frmMenu = new FrmMenu();
                frmMenu.Show();
                this.Hide();
                frmMenu.FormClosed += CerrarSesion;
                /*this.ShowInTaskbar = false;
                this.ShowInTaskbar = true;
                txtUsuario.Clear();*/
            }
        }
        #endregion

        private void btnrCerrar_Click(object sender, EventArgs e)
        {
            Cerrar();
        }

        private void lnklRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRegistro frm = new FrmRegistro();
            this.Hide();
            frm.ShowDialog();
            this.Show();
            if (usuario!=null)
            {
                usuario = _manejadorUsuario.ingresarUsuario(usuario.IdUsuario, true);
                Acceder();
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            usuario=_manejadorUsuario.ingresarUsuario(txtUsuario.Text,false);
            txtUsuario.Clear();
            Acceder();
        }

        private void CerrarSesion(object sender,FormClosedEventArgs e)
        {
            usuario = null;
            this.Show();
        }
    }
}
