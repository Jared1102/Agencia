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
        private Herramienta aux_herramienta=null;
        public FrmHerramienta()
        {
            InitializeComponent();
            _manejadorHerramienta = new ManejadorHerramienta();
            if (FrmHerramientas.herramienta!=null)
            {
                aux_herramienta=FrmHerramientas.herramienta;
                txtDescripcion.Text = FrmHerramientas.herramienta.Descripcion;
                txtMarca.Text = FrmHerramientas.herramienta.Marca;
                txtMedida.Text = FrmHerramientas.herramienta.Medida.ToString();
                txtNombre.Text = FrmHerramientas.herramienta.Nombre;
            }
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
            bool cerrar = true;
            if (FrmHerramientas.herramienta!=null)
            {
                cerrar=_manejadorHerramienta.modificarDatos(new Herramienta
                {
                    CodigoHerramienta = aux_herramienta.CodigoHerramienta,
                    Nombre = txtNombre.Text,
                    Marca = txtMarca.Text,
                    Medida = Convert.ToDecimal(txtMedida.Text),
                    Descripcion = txtDescripcion.Text
                },aux_herramienta);
            }
            else
            {
                _manejadorHerramienta.agregarDatos(new Herramienta
                {
                    CodigoHerramienta = 0,
                    Nombre = txtNombre.Text,
                    Marca = txtMarca.Text,
                    Medida = Convert.ToDecimal(txtMedida.Text),
                    Descripcion = txtDescripcion.Text
                });
            }
            if (cerrar)
            {
                Cerrar();
            }
        }
    }
}
