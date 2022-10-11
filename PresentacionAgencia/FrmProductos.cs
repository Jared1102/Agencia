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
    public partial class FrmProductos : Form
    {
        private ManejadorProducto _manejadorProducto;
        public static Producto producto=null;
        public FrmProductos()
        {
            InitializeComponent();
            _manejadorProducto = new ManejadorProducto();
        }

        #region Componentes
        private void Actualizar()
        {
            _manejadorProducto.obtenerDatos(dgvProductos,FrmSesion.usuario);
        }

        private void Cerrar()
        {
            this.Close();
        }
        #endregion

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            if (!FrmSesion.usuario.PermisosProducto.Crear)
            {
                this.Controls.Remove(btnrAgregar);
            }
            Actualizar();
        }

        private void btnrCerrar_Click(object sender, EventArgs e)
        {
            Cerrar();
        }

        private void btnrAgregar_Click(object sender, EventArgs e)
        {
            FrmProducto frmProducto = new FrmProducto();
            frmProducto.ShowDialog();
            Actualizar();
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            producto = new Producto
            {
                CodigoBarras = int.Parse(dgvProductos.CurrentRow.Cells["CodigoBarras"].Value.ToString()),
                Nombre = dgvProductos.CurrentRow.Cells["Nombre"].Value.ToString(),
                Descripcion = dgvProductos.CurrentRow.Cells["Descripcion"].Value.ToString(),
                Marca = dgvProductos.CurrentRow.Cells["Marca"].Value.ToString()
            };

            if (FrmSesion.usuario.PermisosProducto.Actualizar && FrmSesion.usuario.PermisosProducto.Borrar)
            {
                switch (e.ColumnIndex)
                {
                    case 4:
                        {
                            FrmProducto frmProducto = new FrmProducto();
                            frmProducto.ShowDialog();
                        }
                        break;
                    case 5:
                        {
                            _manejadorProducto.borrarDatos(producto);
                        }
                        break;
                }
            }
            else if (FrmSesion.usuario.PermisosProducto.Borrar && !FrmSesion.usuario.PermisosProducto.Actualizar)
            {
                switch (e.ColumnIndex)
                {
                    case 4:
                        {
                            _manejadorProducto.borrarDatos(producto);
                        }
                        break;
                }
            }
            else if (!FrmSesion.usuario.PermisosProducto.Borrar && FrmSesion.usuario.PermisosProducto.Actualizar)
            {
                switch (e.ColumnIndex)
                {
                    case 4:
                        {
                            FrmProducto frmProducto = new FrmProducto();
                            frmProducto.ShowDialog();
                        }
                        break;
                }
            }

            producto = null;
            Actualizar();
        }
    }
}
