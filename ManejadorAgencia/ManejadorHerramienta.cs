using System;
using System.Collections.Generic;
using System.Drawing;
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
            try
            {
                _accesoDatosHerramienta.AgregarHerramientas(dato);
                _grafico.Mensaje(string.Format("Se agrego con exito {0}", dato.Nombre), "Agregando Herramienta", MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                _grafico.Mensaje(string.Format("Ha ocurrido un error inesperado\n{0}", ex), "Error al agregar", MessageBoxIcon.Error);
            }
        }

        public void borrarDatos(dynamic dato)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show(string.Format("¿Esta seguro de borrar {0}?", dato.Nombre), "Borrando Herramienta",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                    _accesoDatosHerramienta.EliminarHerramienta(dato);
            }
            catch (Exception ex)
            {
                _grafico.Mensaje(string.Format("Ha ocurrido un error inesperado\n{0}", ex), "Error al borrar", MessageBoxIcon.Error);
            }
        }

        public bool modificarDatos(dynamic dato, dynamic aux_dato)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show(string.Format("¿Esta seguro de guardar los cambios en {0}?\n", aux_dato.Nombre),
                    "Modificando Herramienta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == dialogResult)
                {
                    _accesoDatosHerramienta.ModificarHerramientas(dato);
                    return true;
                }

            }
            catch (Exception ex)
            {
                _grafico.Mensaje(string.Format("Ha ocurrido un error inesperado\n{0}", ex), "Error al modificar", MessageBoxIcon.Error);
            }
            return false;
        }

        public void obtenerDatos(DataGridView tabla)
        {
            tabla.Columns.Clear();
            tabla.DataSource = _accesoDatosHerramienta.obtenerHerramientas();

            tabla.Columns.Insert(5, _grafico.Boton("Modificar", Color.Green));
            tabla.Columns.Insert(6, _grafico.Boton("Eliminar", Color.Red));

            tabla.AutoResizeRows();
        }
    }
}
