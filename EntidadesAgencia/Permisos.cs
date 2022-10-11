using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAgencia
{
    public class Permisos
    {
        private bool _Crear;
        private bool _Leer;
        private bool _Actualizar;
        private bool _Borrar;
        public bool Crear { get => _Crear; set => _Crear = value; }
        public bool Leer { get => _Leer; set => _Leer = value; }
        public bool Actualizar { get => _Actualizar; set => _Actualizar = value; }
        public bool Borrar { get => _Borrar; set => _Borrar = value; }
    }
}
