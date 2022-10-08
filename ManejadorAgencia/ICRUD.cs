using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesAgencia;

namespace ManejadorAgencia
{
    internal interface ICRUD
    {
        void obtenerDatos(DataGridView tabla);
        void agregarDatos(dynamic dato);
        bool modificarDatos(dynamic dato, dynamic aux_dato);
        void borrarDatos(dynamic dato);
    }
}
