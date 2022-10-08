﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using EntidadesAgencia;

namespace AccesoDatosAgencia
{
    public class AccesoDatosProducto
    {
        private Conexion _conexion;
        public AccesoDatosProducto()
        {
            _conexion = new Conexion("localhost", "root", "", "agencia", 3306);
        }

        public List<Producto> ObtenerProductos()
        {
            var listProducto = new List<Producto>();
            var ds = new DataSet();
            string consulta = "SELECT * FROM producto;";

            ds = _conexion.ObtenerDatos(consulta, "producto");

            var dt = new DataTable();
            dt = ds.Tables[0];

            foreach (DataRow row in dt.Rows)
            {
                var Producto = new Producto{
                    CodigoBarras = Convert.ToInt32(row["CodigoBarras"]),
                    Nombre = row["Nombre"].ToString(),
                    Descripcion = row["Descripcion"].ToString(),
                    Marca = row["Marca"].ToString()
                };
                listProducto.Add(Producto);
            }
            return listProducto;
        }
    }
}
