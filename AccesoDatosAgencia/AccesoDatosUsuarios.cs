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
                    PermisosProducto = obtenerPermisosProducto(row["IdUsuario"].ToString()),
                    PermisosHerramienta = obtenerPermisosHerramienta(row["IdUsuario"].ToString())
                };
            }
            return null;
        }

        private PermisosHerramienta obtenerPermisosHerramienta(string v)
        {
            string consulta = string.Format("SELECT * FROM v_PermisosHerramienta WHERE IdUsuario='{0}';", v);
            var ds = new DataSet();
            ds = _conexion.ObtenerDatos(consulta, "v_permisosherramienta");

            var dt = new DataTable();
            dt = ds.Tables[0];

            foreach (DataRow row in dt.Rows)
            {
                return new PermisosHerramienta
                {
                    IdPermisoHerramienta = Convert.ToInt32(row["IdPermisoHerramienta"].ToString()),
                    Crear = Convert.ToBoolean(row["Crear"]),
                    Leer = Convert.ToBoolean(row["Leer"]),
                    Borrar = Convert.ToBoolean(row["Borrar"]),
                    Actualizar = Convert.ToBoolean(row["Actualizar"])
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
            
            consulta = string.Format("CALL p_Permiso(0,{0},{1},{2},{3},'{4}',1)",
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

            consulta = string.Format("CALL p_Permiso(0,{0},{1},{2},{3},'{4}',1)",
                usuario.PermisosHerramienta.Crear.ToString(),
                usuario.PermisosHerramienta.Leer.ToString(),
                usuario.PermisosHerramienta.Actualizar.ToString(),
                usuario.PermisosHerramienta.Borrar.ToString(),
                usuario.IdUsuario
                );
            _conexion.EjecutarConsola(consulta);

            consulta = string.Format("CALL p_permisoHerramienta(0,{0},1)",
                obtenerIdPermiso(usuario.IdUsuario));
            _conexion.EjecutarConsola(consulta);
        }

        private string obtenerIdPermiso(string idUsuario)
        {
            string consulta = string.Format("SELECT MAX(IdPermiso) FROM permiso WHERE fkIdUsuario='{0}';", 
                idUsuario);
            var ds = new DataSet();

            ds = _conexion.ObtenerDatos(consulta, "permiso");

            var dt = new DataTable();
            dt = ds.Tables[0];

            foreach (DataRow row in dt.Rows)
            {
                return row["MAX(IdPermiso)"].ToString();
            }
            return null;
        }

        public void modificarUsuario(Usuario usuario)
        {
            /*string consulta = string.Format("CALL p_permisoProducto({0},{1},2)",
                usuario.PermisosProducto.IdPermisoProducto,
                obtenerIdentificadorPermisoProducto(usuario.PermisosProducto.IdPermisoProducto));
            _conexion.EjecutarConsola(consulta);*/

            string consulta = string.Format("CALL p_Permiso({0},{1},{2},{3},{4},'{5}',2)",
                obtenerIdentificadorPermisoProducto(usuario.PermisosProducto.IdPermisoProducto),
                usuario.PermisosProducto.Crear.ToString(),
                usuario.PermisosProducto.Leer.ToString(),
                usuario.PermisosProducto.Actualizar.ToString(),
                usuario.PermisosProducto.Borrar.ToString(),
                usuario.IdUsuario
                );
            _conexion.EjecutarConsola(consulta);

            /*consulta = string.Format("CALL p_permisoHerramienta({0},{1},2);",
                usuario.PermisosHerramienta.IdPermisoHerramienta.ToString(),
                obtenerIdentificadorPermisoHerramienta(usuario.PermisosHerramienta.IdPermisoHerramienta));
            _conexion.EjecutarConsola(consulta);*/

            consulta=string.Format("CALL p_Permiso({0},{1},{2},{3},{4},'{5}',2)",
                obtenerIdentificadorPermisoHerramienta(usuario.PermisosHerramienta.IdPermisoHerramienta),
                usuario.PermisosHerramienta.Crear.ToString(),
                usuario.PermisosHerramienta.Leer.ToString(),
                usuario.PermisosHerramienta.Actualizar.ToString(),
                usuario.PermisosHerramienta.Borrar.ToString(),
                usuario.IdUsuario
                );
            _conexion.EjecutarConsola(consulta);

            consulta = string.Format("CALL p_Usuario('{0}','{1}','{2}','{3}','{4}','{5}',2);",
                usuario.IdUsuario,
                usuario.Nombre,
                usuario.ApellidoP,
                usuario.ApellidoM,
                usuario.FechaNacimiento,
                usuario.RFC);
            _conexion.EjecutarConsola(consulta);
        }

        private string obtenerIdentificadorPermisoHerramienta(int idPermisoHerramienta)
        {
            string consulta = string.Format("SELECT fkIdPermiso FROM permisoherramienta WHERE IdPermisoHerramienta = {0};",
                idPermisoHerramienta);
            var ds = new DataSet();

            ds = _conexion.ObtenerDatos(consulta, "permisoherramienta");

            var dt = new DataTable();
            dt = ds.Tables[0];

            foreach (DataRow row in dt.Rows)
            {
                return row["fkIdPermiso"].ToString();
            }
            return null;
        }

        private string obtenerIdentificadorPermisoProducto(int idPermisoProducto)
        {
            string consulta = string.Format("SELECT fkIdPermiso FROM permisoproducto WHERE IdPermisoProducto = {0};",
                idPermisoProducto);
            var ds = new DataSet();

            ds = _conexion.ObtenerDatos(consulta, "permisoproducto");

            var dt = new DataTable();
            dt = ds.Tables[0];

            foreach (DataRow row in dt.Rows)
            {
                return row["fkIdPermiso"].ToString();
            }
            return null;
        }

        public void eliminarUsuario(Usuario usuario)
        {
            string idPermiso = obtenerIdentificadorPermisoProducto(usuario.PermisosProducto.IdPermisoProducto);
            string consulta = string.Format("CALL p_permisoProducto({0},{1},3)",
                usuario.PermisosProducto.IdPermisoProducto.ToString(),
                obtenerIdentificadorPermisoProducto(usuario.PermisosProducto.IdPermisoProducto));
            _conexion.EjecutarConsola(consulta);

            consulta = string.Format("CALL p_Permiso({0},{1},{2},{3},{4},'{5}',3)",
                idPermiso,
                usuario.PermisosProducto.Crear.ToString(),
                usuario.PermisosProducto.Leer.ToString(),
                usuario.PermisosProducto.Actualizar.ToString(),
                usuario.PermisosProducto.Borrar.ToString(),
                usuario.IdUsuario
                );
            _conexion.EjecutarConsola(consulta);

            idPermiso = obtenerIdentificadorPermisoHerramienta(usuario.PermisosHerramienta.IdPermisoHerramienta);
            consulta = string.Format("CALL p_permisoHerramienta({0},{1},3)",
                usuario.PermisosHerramienta.IdPermisoHerramienta.ToString(), idPermiso);
            _conexion.EjecutarConsola(consulta);

            consulta = string.Format("CALL p_Permiso({0},{1},{2},{3},{4},'{5}',3)",
                idPermiso,
                usuario.PermisosHerramienta.Crear.ToString(),
                usuario.PermisosHerramienta.Leer.ToString(),
                usuario.PermisosHerramienta.Actualizar.ToString(),
                usuario.PermisosHerramienta.Borrar.ToString(),
                usuario.IdUsuario
                );
            _conexion.EjecutarConsola(consulta);

            consulta = string.Format("CALL p_Usuario('{0}','{1}','{2}','{3}','{4}','{5}',3);",
                usuario.IdUsuario,
                usuario.Nombre,
                usuario.ApellidoP,
                usuario.ApellidoM,
                string.Format("2000-11-11"),
                usuario.RFC);
            _conexion.EjecutarConsola(consulta);
        }
    }
}
