using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatosAgencia;
using Crud;

namespace ManejadorAgencia
{
    public class ManejadorHerramienta:ICRUD
    {
        private AccesoDatosHerramienta _accesoDatosHerramienta = new AccesoDatosHerramienta();
        private Grafico _grafico = new Grafico();

        public void agregarDatos(dynamic dato)
        {
            throw new NotImplementedException();
        }

        public void borrarDatos(dynamic dato)
        {
            throw new NotImplementedException();
        }

        public bool modificarDatos(dynamic dato, dynamic aux_dato)
        {
            throw new NotImplementedException();
        }

        public void obtenerDatos(DataGridView tabla)
        {
            tabla.Columns.Clear();
            tabla.DataSource = _accesoDatosHerramienta.obtenerHerramientas();

            tabla.AutoResizeColumns();
        }
    }
}
