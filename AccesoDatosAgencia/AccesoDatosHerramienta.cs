using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using EntidadesAgencia;

namespace AccesoDatosAgencia
{
    public class AccesoDatosHerramienta
    {
        private Conexion _conexion;
        public AccesoDatosHerramienta()
        {
            _conexion = new Conexion("localhost", "root", "", "agencia", 3306);
        }

        public List<Herramienta> obtenerHerramientas()
        {
            var listHerramienta = new List<Herramienta>();
            var ds = new DataSet();
            string consulta = "SELECT * FROM herramienta";

            ds = _conexion.ObtenerDatos(consulta, "herramienta");

            var dt = new DataTable();
            dt = ds.Tables[0];

            foreach (DataRow row in dt.Rows)
            {
                var Herramienta = new Herramienta
                {
                    CodigoHerramienta = Convert.ToInt32(row["CodigoHerramienta"].ToString()),
                    Nombre = row["Nombre"].ToString(),
                    Medida = Convert.ToDecimal(row["Medida"].ToString()),
                    Marca = row["Marca"].ToString(),
                    Descripcion = row["Descripcion"].ToString()
                };
                listHerramienta.Add(Herramienta);
            }
            return listHerramienta;
        }

        public void AgregarHerramientas(Herramienta herramienta)
        {
            string consulta = string.Format("CALL p_Herramienta({0},'{1}'," +
                "{2},'{3}','{4}',1)",
                herramienta.CodigoHerramienta.ToString(),
                herramienta.Nombre,
                herramienta.Medida.ToString(),
                herramienta.Marca,
                herramienta.Descripcion);
            _conexion.EjecutarConsola(consulta);
        }

        public void ModificarHerramientas(Herramienta herramienta)
        {
            string consulta = string.Format("CALL p_Herramienta({0},'{1}'," +
                "{2},'{3}','{4}',2)",
                herramienta.CodigoHerramienta.ToString(),
                herramienta.Nombre,
                herramienta.Medida.ToString(),
                herramienta.Marca,
                herramienta.Descripcion);
            _conexion.EjecutarConsola(consulta);
        }
    }
}
