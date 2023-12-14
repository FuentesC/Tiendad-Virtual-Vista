using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend.Entidades
{
    public class Codigo
    {
        public int codigoID { get; set; }
        public string codigo { get; set; }
        public double descuento { get; set; }
    }
}