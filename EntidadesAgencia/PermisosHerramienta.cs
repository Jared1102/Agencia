using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAgencia
{
    public class PermisosHerramienta:Permisos
    {
        private int _IdPermisoHerramienta;

        public int IdPermisoHerramienta { get => _IdPermisoHerramienta; set => _IdPermisoHerramienta = value; }
    }
}
