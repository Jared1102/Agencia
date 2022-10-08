using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAgencia
{
    public class Herramienta
    {
        private int _CodigoHerramienta;
        private string _Nombre;
        private decimal _Medida;
        private string _Marca;
        private string _Descripcion;

        public int CodigoHerramienta { get => _CodigoHerramienta; set => _CodigoHerramienta = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public decimal Medida { get => _Medida; set => _Medida = value; }
        public string Marca { get => _Marca; set => _Marca = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
    }
}
