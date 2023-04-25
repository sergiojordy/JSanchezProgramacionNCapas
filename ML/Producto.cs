﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public double PrecioUnitario { get; set; }
        public int Stock { get; set; }
        public string Descripcion { get; set; }
        public ML.Proveedor Proveedor { get; set; }
        public ML.Departamento Departamento { get; set; }
    }
}
