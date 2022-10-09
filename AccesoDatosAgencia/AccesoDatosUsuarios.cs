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
                    RFC = row["RFC"].ToString(),
                    PermisosProducto = obtenerPermisosProducto(row["IdUsuario"].ToString())
                };
            }
            return null;
        }

        private PermisosProducto obtenerPermisosProducto(string v)
        {
            string consulta = string.Format("SELECT * FROM v_PermisosProducto WHERE IdUsuario='{0}';", v);
            var ds = new DataSet();
            ds = _conexion.ObtenerDatos(consulta, "v_permisosproducto");

            var dt = new DataTable();
            dt = ds.Tables[0];

            foreach (DataRow row in dt.Rows)
            {
                return new PermisosProducto
                {
                    IdPermisoProducto = Convert.ToInt32(row["IdPermisoProducto"].ToString()),
                    Crear = Convert.ToBoolean(row["Crear"]),
                    Leer = Convert.ToBoolean(row["Leer"]),
                    Borrar = Convert.ToBoolean(row["Borrar"]),
                    Actualizar = Convert.ToBoolean(row["Actualizar"])
                };
            }
            return null;
        }

        public void registrarUsuario(Usuario usuario)
        {
            string consulta=string.Format("CALL p_Usuario('{0}','{1}','{2}','{3}','{4}','{5}',1);",
                usuario.IdUsuario,
                usuario.Nombre,
                usuario.ApellidoP,
                usuario.ApellidoM,
                usuario.FechaNacimiento,
                usuario.RFC);
            _conexion.EjecutarConsola(consulta);
            
            consulta = string.Format("CALL p_Permiso(0,{0},{1},{2},{3},{4},'{5}',1)",
                usuario.PermisosProducto.Crear.ToString(),
                usuario.PermisosProducto.Leer.ToString(),
                usuario.PermisosProducto.Actualizar.ToString(),
                usuario.PermisosProducto.Borrar.ToString(),
                usuario.IdUsuario
                );
            _conexion.EjecutarConsola(consulta);

            consulta = string.Format("CALL p_permisoProducto(0,{0},1)",
                obtenerIdPermiso(usuario.IdUsuario));
            _conexion.EjecutarConsola(consulta);
        }

        private string obtenerIdPermiso(string idUsuario)
        {
            string consulta = string.Format("SELECT * FROM permiso WHERE fkIdUsuario='{0}';", 
                idUsuario);
            var ds = new DataSet();

            ds = _conexion.ObtenerDatos(consulta, "permiso");

            var dt = new DataTable();
            dt = ds.Tables[0];

            foreach (DataRow row in dt.Rows)
            {
                return row["IdUsuario"].ToString();
            }
            return null;
        }
    }
}
