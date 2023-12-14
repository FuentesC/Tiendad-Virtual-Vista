using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using Backend.AccesoDatos;
using Backend.Entidades;

namespace Backend.Utilitarios
{
    public class Factory
    {
        public static Usuario factoryListaUsuarios(ObtenerListaUsuariosResult usuariosComplejos)
        {

            Usuario usuario = new Usuario();
            usuario.usuarioID = usuariosComplejos.UsuarioID;
            usuario.nombre = usuariosComplejos.Nombre;
            usuario.apellidos = usuariosComplejos.Apellidos;
            usuario.edad = usuariosComplejos.Edad;
            usuario.nombreUsuario = usuariosComplejos.NombreUsuario;
            usuario.correo = usuariosComplejos.CorreoElectronico;
            usuario.contrasena = usuariosComplejos.Contrasena;
            usuario.fechaRegistro = usuariosComplejos.FechaRegistro;
            usuario.rolID = usuariosComplejos.RolID;

            return usuario;
        }

        public static Usuario factoryObtenerUnUsuario(ObtenerUsuarioResult unUsuarioTipoComplejo)
        {

            Usuario usuario = new Usuario();

            usuario.usuarioID = unUsuarioTipoComplejo.UsuarioID;
            usuario.nombre = unUsuarioTipoComplejo.Nombre;
            usuario.apellidos = unUsuarioTipoComplejo.Apellidos;
            usuario.edad = unUsuarioTipoComplejo.Edad;
            usuario.nombreUsuario = unUsuarioTipoComplejo.NombreUsuario;
            usuario.correo = unUsuarioTipoComplejo.CorreoElectronico;
            usuario.contrasena = unUsuarioTipoComplejo.Contrasena;
            usuario.fechaRegistro = unUsuarioTipoComplejo.FechaRegistro;
            usuario.rolID = unUsuarioTipoComplejo.RolID;

            return usuario;
        }

        public static Usuario factoryLogin(pa_LoginResult loginComplejo)
        {
            Usuario usuario = new Usuario();

            usuario.usuarioID = loginComplejo.UsuarioID;
            usuario.nombreUsuario = loginComplejo.NombreUsuario;
            usuario.contrasena = loginComplejo.Contraseña;

            return usuario;
        }

        public static Codigo factoryCodigo(ValidarCodigoResult codigoComplejo) { 
            
            Codigo codigo = new Codigo();
            codigo.codigoID = codigoComplejo.CodigoID;
            codigo.codigo = codigoComplejo.Codigo;
            codigo.descuento = Convert.ToDouble(codigoComplejo.Descuento);
            return codigo;
        }

        public static List<Juego> factoryListaJuegos(List<ObtenerListaJuegosResult> listaComplejaJuego)
        {

            List<Juego> listaJuegos = new List<Juego>();

            foreach (ObtenerListaJuegosResult cadaJuegoTipoComplejo in listaComplejaJuego)
            {
                listaJuegos.Add(factoryUnJuego(cadaJuegoTipoComplejo));
            }

            return listaJuegos;
        }

        public static Juego factoryUnJuego(ObtenerListaJuegosResult tipoComplejo)
        {

            Juego juego = new Juego();

            juego.juegoID = tipoComplejo.JuegoID;
            //juego.slug = 
            //juego.nombre =
            //juego.added = 
            juego.desarrollador = tipoComplejo.Desarrollador;
            juego.genero = tipoComplejo.Genero;
            juego.precio = (int)tipoComplejo.Precio;
            juego.fechaLanzamiento = tipoComplejo.FechaLanzamiento;
            juego.descripcion = tipoComplejo.Descripcion;

            return juego;
        }

        public static List<Resena> factoryListaResenas(List<ObtenerResenasResult> listaCompleja) { 
            
            List<Resena> listaResenas = new List<Resena>();

            foreach (ObtenerResenasResult resenaCompleja in listaCompleja) {
                listaResenas.Add(factoryUnaResena(resenaCompleja));
            }

            return listaResenas;
        }

        public static Resena factoryUnaResena(ObtenerResenasResult resenaCompleja) { 
            
            Resena resena = new Resena();

            resena.usuarioID = resenaCompleja.UsuarioID;
            resena.juegoID = resenaCompleja.JuegoID;
            resena.comentario = resenaCompleja.Comentario;
            resena.fechaResena = Convert.ToDateTime(resenaCompleja.FechaReseña);

            return resena;
        }
    }
}