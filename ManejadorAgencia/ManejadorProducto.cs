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
    public class ManejadorProducto : IProducto
    {
        private AccesoDatosProducto _accesoDatosProducto = new AccesoDatosProducto();
        private Grafico _grafico = new Grafico();
        public void agregarDatos(dynamic dato)
        {
            try
            {
                _accesoDatosProducto.AgregarProducto(dato);
                _grafico.Mensaje(string.Format("Se agrego con exito {0}", dato.Nombre),"Agregando Producto",MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                _grafico.Mensaje(string.Format("Ha ocurrido un error inesperado\n{0}",ex), "Error al agregar", MessageBoxIcon.Error);
            }
            
        }

        public void borrarDatos(dynamic dato)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show(string.Format("¿Esta seguro de borrar {0}?", dato.Nombre),"Borrando Producto",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                _accesoDatosProducto.EliminarProducto(dato);
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
                    "Modificando Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == dialogResult)
                {
                    _accesoDatosProducto.ModificarProducto(dato);
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
            tabla.DataSource = _accesoDatosProducto.ObtenerProductos();

            tabla.Columns.Insert(4, _grafico.Boton("Modificar", Color.Green));
            tabla.Columns.Insert(5, _grafico.Boton("Eliminar", Color.Red));

            tabla.AutoResizeColumns();
        }
    }
}
