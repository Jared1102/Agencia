using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesAgencia;
using ManejadorAgencia;

namespace PresentacionAgencia
{
    public partial class FrmRegistro : Form
    {
        private ManejadorUsuario _manejadorUsuario;
        public FrmRegistro()
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

        private void btnrCerrar_Click(object sender, EventArgs e)
        {
            Cerrar();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            FrmSesion.usuario = new Usuario
            {
                IdUsuario = txtIdUsuario.Text,
                Nombre = txtNombre.Text,
                ApellidoP = txtApellidoP.Text,
                ApellidoM = txtApellidoM.Text,
                FechaNacimiento = string.Format("{0}-{1}-{2}", dtpNacimiento.Value.Year, dtpNacimiento.Value.Month, dtpNacimiento.Value.Day),
                RFC = txtRFC.Text,
                PermisosProducto = new PermisosProducto { 
                    IdPermisoProducto=0,
                    Crear = ckbCrearProductos.Checked,
                    Actualizar = ckbModificarProductos.Checked,
                    Borrar = ckbEliminarProductos.Checked,
                    Leer = obtenerLectura(ckbCrearProductos.Checked, ckbModificarProductos.Checked, ckbEliminarProductos.Checked)
                },
                PermisosHerramienta = new PermisosHerramienta
                {
                    IdPermisoHerramienta = 0,
                    Crear = ckbCrearHerramientas.Checked,
                    Actualizar = ckbModificarHerramientas.Checked,
                    Borrar = ckbEliminarHerramientas.Checked,
                    Leer = obtenerLectura(ckbCrearHerramientas.Checked, ckbModificarHerramientas.Checked, ckbEliminarHerramientas.Checked)
                }
            };
            _manejadorUsuario.registrarUsuario(FrmSesion.usuario);
            this.Close();
        }

        
    }
}
