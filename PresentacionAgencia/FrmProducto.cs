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

        public FrmProducto()
        {
            InitializeComponent();
            _manejadorProducto = new ManejadorProducto();
        }

        #region Componentes
        private void Cerrar()
        {
            this.Close();
        }
        #endregion

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            _manejadorProducto.agregarDatos(new Producto {
                CodigoBarras=0,
                Nombre=txtNombre.Text,
                Marca =txtMarca.Text,
                Descripcion=txtDescripcion.Text
            });
            Cerrar();
        }
    }
}
