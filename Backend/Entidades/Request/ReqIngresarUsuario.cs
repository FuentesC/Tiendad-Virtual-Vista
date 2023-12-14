using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend.Entidades
{
    public class ReqIngresarUsuario
    {
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public int edad { get; set; }
        public string nombreUsuario { get; set; }
        public string correo { get; set; }
        public string contrasena { get; set; }
    }
}