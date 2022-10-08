using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAgencia
{
    public class Producto
    {
        private int _CodigoBarras;
        private string _Nombre;
        private string _Descripcion;
        private string _Marca;

        public int CodigoBarras { get => _CodigoBarras; set => _CodigoBarras = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public string Marca { get => _Marca; set => _Marca = value; }
    }
}
