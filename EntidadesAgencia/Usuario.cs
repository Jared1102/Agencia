using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAgencia
{
    public class Usuario
    {
        private string _IdUsuario;
        private string _Nombre;
        private string _ApellidoP;
        private string _ApellidoM;
        private string _FechaNacimiento;
        private string _RFC;

        private PermisosProducto _permisosProducto;
        private PermisosHerramienta _permisosHerramienta;

        public string IdUsuario { get => _IdUsuario; set => _IdUsuario = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string ApellidoP { get => _ApellidoP; set => _ApellidoP = value; }
        public string ApellidoM { get => _ApellidoM; set => _ApellidoM = value; }
        public string FechaNacimiento { get => _FechaNacimiento; set => _FechaNacimiento = value; }
        public string RFC { get => _RFC; set => _RFC = value; }
        public PermisosProducto PermisosProducto { get => _permisosProducto; set => _permisosProducto = value; }
        public PermisosHerramienta PermisosHerramienta { get => _permisosHerramienta; set => _permisosHerramienta = value; }
    }
}
