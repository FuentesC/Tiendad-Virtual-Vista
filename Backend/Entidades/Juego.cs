using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend.Entidades
{
    public class Juego
    {
        public int juegoID { get; set; } //Datos del API que se debe guardar en BD
        public string slug { get; set; } //Datos del APi
        public string nombre { get; set; } //Datos del API
        public int added { get; set; } //Datos del API
        public string desarrollador { get; set; } //Datos de BD
        public string genero { get; set; } //Datos de BD
        public int precio { get; set; } //Datos de BD
        public DateTime fechaLanzamiento { get; set; } //Datos de BD
        public string descripcion { get; set; } //Datos de BD
    }
}