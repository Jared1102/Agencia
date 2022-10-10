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

namespace PresentacionAgencia
{
    public partial class FrmUsuario : Form
    {
        private ManejadorUsuario _manejadorUsuario;
        public FrmUsuario()
        {
            InitializeComponent();
            _manejadorUsuario = new ManejadorUsuario();
        }
        #region Componentes
        private void Cerrar()
        {
            this.Close();
        }

        private bool obtenerLectura(bool checked1, bool checked2, bool checked3)
        {
            if (checked1 || checked2 || checked3)
            {
                return true;
            }
            return false;
        }
        #endregion
        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            lUsuario.Text = FrmSesion.usuario.IdUsuario;
            lUsuario.Location = new Point((panel1.Width - lUsuario.Width) / 2, 38);

            txtApellidoM.Text = FrmSesion.usuario.ApellidoM;
            txtApellidoP.Text = FrmSesion.usuario.ApellidoP;
            txtNombre.Text = FrmSesion.usuario.Nombre;
            txtRFC.Text = FrmSesion.usuario.RFC;
            dtpNacimiento.Text = FrmSesion.usuario.FechaNacimiento;
            //Productos
            ckbCrearProductos.Checked = FrmSesion.usuario.PermisosProducto.Crear;
            ckbModificarProductos.Checked = FrmSesion.usuario.PermisosProducto.Actualizar;
            ckbEliminarProductos.Checked = FrmSesion.usuario.PermisosProducto.Borrar;
            //Herramientas
            ckbCrearHerramientas.Checked = FrmSesion.usuario.PermisosHerramienta.Crear;
            ckbModificarHerramientas.Checked = FrmSesion.usuario.PermisosHerramienta.Actualizar;
            ckbEliminarHerramientas.Checked = FrmSesion.usuario.PermisosHerramienta.Borrar;
        }

        private void btnrCerrar_Click(object sender, EventArgs e)
        {
            Cerrar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            FrmSesion.usuario.ApellidoM=txtApellidoM.Text;
            FrmSesion.usuario.ApellidoP= txtApellidoP.Text;
            FrmSesion.usuario.Nombre=txtNombre.Text;
            FrmSesion.usuario.RFC= txtRFC.Text;
            FrmSesion.usuario.FechaNacimiento = string.Format("{0}-{1}-{2}", dtpNacimiento.Value.Year, dtpNacimiento.Value.Month, dtpNacimiento.Value.Day);
            //Productos
            FrmSesion.usuario.PermisosProducto.Crear=ckbCrearProductos.Checked;
            FrmSesion.usuario.PermisosProducto.Actualizar=ckbModificarProductos.Checked;
            FrmSesion.usuario.PermisosProducto.Borrar=ckbEliminarProductos.Checked;
            FrmSesion.usuario.PermisosProducto.Leer = obtenerLectura(ckbCrearProductos.Checked, ckbModificarProductos.Checked, 
                ckbEliminarProductos.Checked);
            //Herramientas
            FrmSesion.usuario.PermisosHerramienta.Crear=ckbCrearHerramientas.Checked;
            FrmSesion.usuario.PermisosHerramienta.Actualizar=ckbModificarHerramientas.Checked;
            FrmSesion.usuario.PermisosHerramienta.Borrar=ckbEliminarHerramientas.Checked;
            FrmSesion.usuario.PermisosHerramienta.Leer = obtenerLectura(ckbCrearHerramientas.Checked, ckbModificarHerramientas.Checked,
                ckbEliminarHerramientas.Checked);
            _manejadorUsuario.modificarUsuario(FrmSesion.usuario);
            Cerrar();
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            _manejadorUsuario.borrarUsuario(FrmSesion.usuario);
            Application.Exit();
        }
    }
}
