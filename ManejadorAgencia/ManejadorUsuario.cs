using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatosAgencia;
using EntidadesAgencia;

namespace ManejadorAgencia
{
    public class ManejadorUsuario
    {
        private AccesoDatosUsuarios _accesoDatosUsuarios = new AccesoDatosUsuarios();

        public Usuario ingresarUsuario(string IdUsuario)
        {
            return _accesoDatosUsuarios.buscarUsuario(IdUsuario);
        }
    }
}
