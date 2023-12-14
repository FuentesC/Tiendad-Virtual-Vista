using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace Backend.Entidades
{
    public class Usuario
    {
        public int usuarioID { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public int edad { get; set; }
        public string nombreUsuario { get; set; }
        public string correo { get; set; }
        public string contrasena { get; set; }
        public DateTime fechaRegistro { get; set; }
        public int? rolID { get; set; } //Acá se agregó el ? porque hubo un error en BD, el campo RolId
        //en la BD se creó primero null y luego se cambio a NOT NULL
    }
}