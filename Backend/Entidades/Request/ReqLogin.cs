using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend.Entidades
{
    public class ReqLogin
    {
        public string nombreUsuario { get; set; }
        public string contrasena { get; set; }
    }
}