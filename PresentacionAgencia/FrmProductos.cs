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
        public FrmProductos()
        {
            InitializeComponent();
            _manejadorProducto = new ManejadorProducto();
        }

        #region Componentes
        private void Actualizar()
        {
            _manejadorProducto.obtenerDatos(dgvProductos);
        }

        private void Cerrar()
        {
            this.Close();
        }
        #endregion

        private void FrmProductos_Load(object sender, EventArgs e)
        {
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
    }
}
