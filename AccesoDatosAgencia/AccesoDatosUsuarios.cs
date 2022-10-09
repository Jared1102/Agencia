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
    public class AccesoDatosUsuarios
    {
        private Conexion _conexion;
        public AccesoDatosUsuarios()
        {
            _conexion = new Conexion("localhost", "root", "", "agencia", 3306);
        }

        public Usuario buscarUsuario(string usuario)
        {
            string consulta = string.Format("SELECT * FROM usuario WHERE IdUsuario='{0}'", usuario);
            var ds = new DataSet();

            ds = _conexion.ObtenerDatos(consulta, "usuario");

            var dt = new DataTable();
            dt = ds.Tables[0];

            foreach (DataRow row in dt.Rows)
            {
                return new Usuario
                {
                    IdUsuario = row["IdUsuario"].ToString(),
                    Nombre = row["Nombre"].ToString(),
                    ApellidoM = row["ApellidoM"].ToString(),
                    ApellidoP = row["ApellidoP"].ToString(),
                    FechaNacimiento = DateTime.Parse(row["FechaNacimiento"].ToString()).ToString("d"),
                    RFC = row["RFC"].ToString()
                };
            }
            return null;
        }
    }
}
