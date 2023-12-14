using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend.Entidades
{
    public class Resena
    {
        public int resenaID { get; set; }
        public int usuarioID { get; set; }
        public int juegoID { get; set; }
        public string comentario { get; set; }
        public DateTime fechaResena { get; set; }
    }
}