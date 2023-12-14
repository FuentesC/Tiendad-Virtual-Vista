using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Backend.AccesoDatos;
using Backend.Entidades;
using Backend.Entidades.Request;
using Backend.Utilitarios;

namespace Backend.Logica
{
    public class Logica_Resena
    {
        public ResIngresarResena ingesarResena(ReqIngresarResena req) {

            ResIngresarResena res = new ResIngresarResena();

            try {
                if (req == null) {
                    res.listDeErrores.Add("Request nulo");
                    res.result = false;
                }
                else {
                    if (String.IsNullOrEmpty(req.resena.usuarioID.ToString())) {
                        res.listDeErrores.Add("ID del usuaario vacío");
                        res.result = false;
                    }
                    if (String.IsNullOrEmpty(req.resena.juegoID.ToString())) {
                        res.listDeErrores.Add("ID del juego vacío");
                        res.result = false;
                    }
                    if (String.IsNullOrEmpty(req.resena.comentario)) {
                        res.listDeErrores.Add("Comentario vacío");
                        res.result = false;
                    }
                    if (!res.listDeErrores.Any()) {

                        conexionLinqDataContext conexion = new conexionLinqDataContext();
                        conexion.AgregarResena(req.resena.usuarioID, req.resena.juegoID, req.resena.comentario);
                    }
                }
            }
            catch (Exception ex) {
                res.listDeErrores.Add("No se pudo agregar la reseña: " + ex);
                res.result = false;
            }

            return res;
        }

        public ResObtenerResenas obtenerListaResenas(ReqObtenerResenas req) { 
            
            ResObtenerResenas res = new ResObtenerResenas();

            res.listDeErrores = new List<string>();

            try {

                if (req == null)
                {
                    res.listDeErrores.Add("Request Nulo");
                    res.result = false;
                }
                else {
                    if (String.IsNullOrEmpty(req.juegoID.ToString())) {
                        res.listDeErrores.Add("Id del juego vacío");
                        res.result = false;
                    }
                    if (!res.listDeErrores.Any()) { 
                        
                        conexionLinqDataContext conexion = new conexionLinqDataContext();
                        List<ObtenerResenasResult> listaResenasComplejas = new List<ObtenerResenasResult>();
                        listaResenasComplejas = conexion.ObtenerResenas(req.juegoID).ToList();
                        res.listaResenas = Factory.factoryListaResenas(listaResenasComplejas);
                        res.result = true;
                    }
                }
            } catch (Exception ex) {
                res.listDeErrores.Add("Error, no se pudo traer las reseñas: " + ex.StackTrace);
                res.result = false;
            }

            return res;
        }
    }
}