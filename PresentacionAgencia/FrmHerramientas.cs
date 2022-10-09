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
        public static Herramienta herramienta=null;
        public FrmHerramientas()
        {
            InitializeComponent();
            _manejadorHerramienta = new ManejadorHerramienta();
        }

        #region Componentes

        private void Actualizar()
        {
            _manejadorHerramienta.obtenerDatos(dgvProductos,FrmSesion.usuario);
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

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            herramienta = new Herramienta
            {
                CodigoHerramienta = Convert.ToInt32(dgvProductos.CurrentRow.Cells["CodigoHerramienta"].Value.ToString()),
                Nombre = dgvProductos.CurrentRow.Cells["Nombre"].Value.ToString(),
                Marca = dgvProductos.CurrentRow.Cells["Marca"].Value.ToString(),
                Medida = Convert.ToDecimal(dgvProductos.CurrentRow.Cells["Medida"].Value.ToString()),
                Descripcion = dgvProductos.CurrentRow.Cells["Descripcion"].Value.ToString()
            };
            switch (e.ColumnIndex)
            {
                case 5: {
                        FrmHerramienta frmHerramienta = new FrmHerramienta();
                        frmHerramienta.ShowDialog();
                    } break;
                case 6: {
                        _manejadorHerramienta.borrarDatos(herramienta);
                    }break;
            }
            herramienta = null;
            Actualizar();
        }
    }
}
