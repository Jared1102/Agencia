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
    public partial class FrmHerramienta : Form
    {
        private ManejadorHerramienta _manejadorHerramienta;
        public FrmHerramienta()
        {
            InitializeComponent();
            _manejadorHerramienta = new ManejadorHerramienta();
        }

        #region Componentes
        private void Cerrar()
        {
            this.Close();
        }
        #endregion

        private void btnrCerrar_Click(object sender, EventArgs e)
        {
            Cerrar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            _manejadorHerramienta.agregarDatos(new Herramienta
            {
                CodigoHerramienta = 0,
                Nombre = txtNombre.Text,
                Marca = txtMarca.Text,
                Medida = Convert.ToDecimal(txtMedida.Text),
                Descripcion = txtDescripcion.Text
            });
            Cerrar();
        }
    }
}
