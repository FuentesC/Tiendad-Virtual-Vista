using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Backend.AccesoDatos;
using Backend.Entidades;
using Backend.Utilitarios;

namespace Backend.Logica
{
    public class Logica_Usuario
    {
        public ResIngresarUsuario ingresarUsuario(ReqIngresarUsuario req)
        {

            ResIngresarUsuario res = new ResIngresarUsuario();

            try
            {
                if (req == null)
                {
                    res.listDeErrores.Add("Request es nulo");
                    res.result = false;
                }
                else
                {
                    if (String.IsNullOrEmpty(req.nombre))
                    {
                        res.listDeErrores.Add("Nombre vacío");
                        res.result = false;
                    }
                    if (String.IsNullOrEmpty(req.apellidos))
                    {
                        res.listDeErrores.Add("Apellidos vacíos");
                        res.result = false;
                    }
                    if (String.IsNullOrEmpty(req.edad.ToString()))
                    {
                        res.listDeErrores.Add("Edad vacía");
                        res.result = false;
                    }
                    if (String.IsNullOrEmpty(req.nombreUsuario))
                    {
                        res.listDeErrores.Add("Nombre de usuario vacío");
                        res.result = false;
                    }
                    if (String.IsNullOrEmpty(req.correo))
                    {
                        res.listDeErrores.Add("Correo electrónico vacío");
                        res.result = false;
                    }
                    if (String.IsNullOrEmpty(req.contrasena.ToString()))
                    {
                        res.listDeErrores.Add("Contraseña vacía");
                        res.result = false;
                    }
                    if (!res.listDeErrores.Any())
                    {

                        conexionLinqDataContext conexion = new conexionLinqDataContext();
                        conexion.InsertarUsuario(req.nombre, req.apellidos, req.edad,
                            req.nombreUsuario, req.correo, req.contrasena,
                            0);
                    }
                }
            }
            catch (Exception ex)
            {
                res.listDeErrores.Add("Error, no se pudo ingresar el usuario: " + ex.StackTrace);
                res.result = false;
            }

            return res;
        }

        public ResObtenerListaUsuarios obtenerListaUsuarios(ReqObtenerListaUsuarios req)
        {

            ResObtenerListaUsuarios res = new ResObtenerListaUsuarios();

            try
            {
                if (req == null)
                {
                    res.listDeErrores.Add("Request es nulo");
                    res.result = false;
                }
                else
                {
                    conexionLinqDataContext conexion = new conexionLinqDataContext();
                    List<ObtenerListaUsuariosResult> listaUsuarios = conexion.ObtenerListaUsuarios().ToList();

                    foreach (ObtenerListaUsuariosResult usuariosComplejos in listaUsuarios)
                    {
                        res.ListaUsuarios.Add(Factory.factoryListaUsuarios(usuariosComplejos));
                    }
                }
            }
            catch (Exception e)
            {
                res.listDeErrores.Add("Error, no se puedo obtener la lista de usuarios: " + e);
                res.result = false;
            }

            return res;
        }

        public ResObtenerUsuario obtenerUsuario(ReqObtenerUsuario req)
        {

            ResObtenerUsuario res = new ResObtenerUsuario();

            try
            {

                if (req == null)
                {
                    res.listDeErrores.Add("Request es nulo");
                    res.result = false;
                }
                else
                {
                    if (String.IsNullOrEmpty(req.idUsuario.ToString()))
                    {
                        res.listDeErrores.Add("Id de usuario vacío");
                        res.result = false;
                    }
                    if (!res.listDeErrores.Any())
                    {

                        conexionLinqDataContext conexion = new conexionLinqDataContext();
                        ObtenerUsuarioResult usuarioComplejo = (ObtenerUsuarioResult)conexion.ObtenerUsuario(req.idUsuario);
                        res.usuario = Factory.factoryObtenerUnUsuario(usuarioComplejo);
                    }
                }

            }
            catch (Exception e)
            {
                res.listDeErrores.Add("Error, no se pudo obtener el usuario: " + e);
                res.result = false;
            }

            return res;
        }

        public ResLogin login(ReqLogin req)
        {

            ResLogin res = new ResLogin();

            try
            {
                if (req == null)
                {
                    res.listDeErrores.Add("Request nulo");
                    res.result = false;
                }
                else
                {
                    if (String.IsNullOrEmpty(req.nombreUsuario))
                    {
                        res.listDeErrores.Add("Nombre de usuario vacío");
                        res.result = false;
                    }
                    if (String.IsNullOrEmpty(req.contrasena))
                    {
                        res.listDeErrores.Add("Contraseña vacía");
                        res.result = false;
                    }
                    if (!res.listDeErrores.Any())
                    {

                        conexionLinqDataContext conexion = new conexionLinqDataContext();
                        pa_LoginResult loginComplejo = (pa_LoginResult)conexion.pa_Login(req.nombreUsuario, req.contrasena);
                        res.usuario = Factory.factoryLogin(loginComplejo);
                    }
                }
            }
            catch (Exception ex)
            {
                res.listDeErrores.Add("Error en login: " + ex);
                res.result = false;
            }

            return res;
        }

        public ResEliminarUsuario eliminarUsuario(ReqEliminarUsuario req) { 
            
            ResEliminarUsuario res = new ResEliminarUsuario();

            try {
                if (req == null)
                {
                    res.listDeErrores.Add("Request nulo");
                    res.result = false;
                }
                else {
                    if (String.IsNullOrEmpty(req.usuarioID.ToString())) {
                        res.listDeErrores.Add("Id del usuario vacío");
                        res.result = false;
                    }
                    if (!res.listDeErrores.Any()) { 
                        
                        conexionLinqDataContext conexion = new conexionLinqDataContext();
                        conexion.EliminarUsuario(req.usuarioID);
                    }
                }
            } catch (Exception ex) {
                res.listDeErrores.Add("Error, no se pudo eliminar el usuario: " + ex.StackTrace);
                res.result = false;
            }

            return res;
        }

        public ResActualizarUsuario actualizarUsuario(ReqActualizarUsuario req) {

            ResActualizarUsuario res = new ResActualizarUsuario();

            try {

                if (req == null) {
                    res.listDeErrores.Add("Request nulo");
                    res.result = false;
                }
                else {
                    if (String.IsNullOrEmpty(req.usuario.usuarioID.ToString())) {
                        res.listDeErrores.Add("Id del usuario vacío");
                        res.result = false;
                    }
                    if (String.IsNullOrEmpty(req.usuario.nombre))
                    {
                        res.listDeErrores.Add("Nombre vacío");
                        res.result = false;
                    }
                    if (String.IsNullOrEmpty(req.usuario.apellidos))
                    {
                        res.listDeErrores.Add("Apellidos vacíos");
                        res.result = false;
                    }
                    if (String.IsNullOrEmpty(req.usuario.edad.ToString()))
                    {
                        res.listDeErrores.Add("Edad vacía");
                        res.result = false;
                    }
                    if (String.IsNullOrEmpty(req.usuario.nombreUsuario))
                    {
                        res.listDeErrores.Add("Nombre de usuario vacío");
                        res.result = false;
                    }
                    if (String.IsNullOrEmpty(req.usuario.correo))
                    {
                        res.listDeErrores.Add("Correo electrónico vacío");
                        res.result = false;
                    }
                    if (String.IsNullOrEmpty(req.usuario.contrasena.ToString()))
                    {
                        res.listDeErrores.Add("Contraseña vacía");
                        res.result = false;
                    }
                    if (String.IsNullOrEmpty(req.usuario.rolID.ToString())) {
                        res.listDeErrores.Add("Rol del usuario vacío");
                        res.result = false;
                    }
                    if (!res.listDeErrores.Any())
                    {
                        conexionLinqDataContext conexion = new conexionLinqDataContext();
                        conexion.ActualizarUsuario(req.usuario.usuarioID, req.usuario.nombre,
                            req.usuario.apellidos, req.usuario.edad, req.usuario.nombreUsuario,
                            req.usuario.correo, req.usuario.contrasena, req.usuario.rolID);
                    }
                }

            } catch (Exception ex) {
                res.listDeErrores.Add("Error, no se pudo actualizar el usuario: " + ex.StackTrace);
                res.result = false;
            }

            return res;
        }
    }
}