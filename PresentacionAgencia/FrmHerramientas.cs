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
    public partial class FrmHerramientas : Form
    {
        private ManejadorHerramienta _manejadorHerramienta;
        public FrmHerramientas()
        {
            InitializeComponent();
            _manejadorHerramienta = new ManejadorHerramienta();
        }

        #region Componentes

        private void Actualizar()
        {
            _manejadorHerramienta.obtenerDatos(dgvProductos);
        }

        private void Cerrar()
        {
            this.Close();
        }
        #endregion

        private void FrmHerramientas_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void btnrCerrar_Click(object sender, EventArgs e)
        {
            Cerrar();
        }

        private void btnrAgregar_Click(object sender, EventArgs e)
        {
            FrmHerramienta frmHerramienta = new FrmHerramienta();
            frmHerramienta.ShowDialog();
            Actualizar();
        }
    }
}
