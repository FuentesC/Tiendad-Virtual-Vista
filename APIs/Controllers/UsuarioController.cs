using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Backend.Entidades;
using Backend.Logica;

namespace APIs.Controllers
{
    public class UsuarioController:ApiController
    {
        //DataNotation
        [HttpPost]
        [Route("api/Usuario/ingresarUsuario")]
        public ResIngresarUsuario ingresarUsuario([FromBody] ReqIngresarUsuario req)
        {

            Logica_Usuario logicaBackend = new Logica_Usuario();
            return logicaBackend.ingresarUsuario(req);
        }
        
        [HttpGet]
        [Route("api/Usuario/GetListaUsuarios")]
        public ResObtenerListaUsuarios GetListaUsuarios()
        {

            Logica_Usuario logicaBackend = new Logica_Usuario();
            ReqObtenerListaUsuarios req = new ReqObtenerListaUsuarios();
            return logicaBackend.obtenerListaUsuarios(req);
        }

        [HttpPost]
        [Route("api/Usuario/obtenerUsuario")]
        public ResObtenerUsuario obtenerUsuario([FromBody] ReqObtenerUsuario req)
        {
            Logica_Usuario logicaBackend = new Logica_Usuario();
            return logicaBackend.obtenerUsuario(req);
        }

        [HttpPost]
        [Route("api/Usuario/deleteUsuario")]
        public ResEliminarUsuario deleteUsuario([FromBody] ReqEliminarUsuario req)
        {
            Logica_Usuario logicaBackend = new Logica_Usuario();
            return logicaBackend.eliminarUsuario(req);
        }

        [HttpPost]
        [Route("api/Usuario/patchUsuario")]
        public ResActualizarUsuario patchUsuario([FromBody] ReqActualizarUsuario req)
        {
            Logica_Usuario logicaBackend = new Logica_Usuario();
            return logicaBackend.actualizarUsuario(req);
        }

        [HttpPost]
        [Route("api/Usuario/GetLogin")]
        public ResLogin GetLogin([FromBody] ReqLogin req)
        {
            Logica_Usuario logicaBackend = new Logica_Usuario();
            return logicaBackend.login(req);
        }
    }
}