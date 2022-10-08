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
    public partial class FrmProducto : Form
    {
        private ManejadorProducto _manejadorProducto;
        private Producto aux_producto=null;
        public FrmProducto()
        {
            InitializeComponent();
            _manejadorProducto = new ManejadorProducto();
            if (FrmProductos.producto!=null)
            {
                aux_producto = FrmProductos.producto;
                txtDescripcion.Text = FrmProductos.producto.Descripcion;
                txtMarca.Text = FrmProductos.producto.Marca;
                txtNombre.Text = FrmProductos.producto.Nombre;
            }
        }

        #region Componentes
        private void Cerrar()
        {
            this.Close();
        }
        #endregion

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool cerrar=true;
            if (FrmProductos.producto!=null)
            {
                cerrar=_manejadorProducto.modificarDatos(new Producto
                {
                    CodigoBarras = aux_producto.CodigoBarras,
                    Nombre = txtNombre.Text,
                    Marca = txtMarca.Text,
                    Descripcion = txtDescripcion.Text
                },aux_producto);
            }
            else
            {
                _manejadorProducto.agregarDatos(new Producto
                {
                    CodigoBarras = 0,
                    Nombre = txtNombre.Text,
                    Marca = txtMarca.Text,
                    Descripcion = txtDescripcion.Text
                });
            }
            if (cerrar)
            {
                Cerrar();
            }
        }

        private void btnrCerrar_Click(object sender, EventArgs e)
        {
            Cerrar();
        }
    }
}
