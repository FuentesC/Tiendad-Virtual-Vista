using Backend.Entidades;
using Backend.Entidades.Response;
using Backend.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace APIs.Controllers
{
    public class JuegoController:ApiController
    {
        /*public ResObtenerListaJuegos GetObtenerListaJuegos()
        {
            Logica_Juego juego = new Logica_Juego();
            ReqObtenerListaJuegos req = new ReqObtenerListaJuegos();
            return juego.obtenerListaJuegos(req);
        }*/

        public ResValidarCodigo GetValidarCodigo([FromBody] ReqValidarCodigo req) { 
            
            Logica_Juego logicaBackend = new Logica_Juego();
            return logicaBackend.validarCodigo(req);
        }
    }
}