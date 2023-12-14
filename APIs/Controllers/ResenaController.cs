using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Backend.Entidades;
using Backend.Entidades.Request;
using Backend.Logica;

namespace APIs.Controllers
{
    public class ResenaController:ApiController
    {
        [HttpPost]
        [Route("api/Usuario/ingresarResena")]
        public ResIngresarResena ingresarResena([FromBody] ReqIngresarResena req)
        {
            Logica_Resena logicaBackend = new Logica_Resena();
            return logicaBackend.ingesarResena(req);
        }

        [HttpPost]
        [Route("api/Usuario/GetObtenerListaResenas")]
        public ResObtenerResenas GetObtenerListaResenas([FromBody] ReqObtenerResenas req) 
        { 
            Logica_Resena logicaBackend = new Logica_Resena();
            return logicaBackend.obtenerListaResenas(req);
        }
    }
}