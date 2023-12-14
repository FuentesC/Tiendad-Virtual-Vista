using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Backend.AccesoDatos;
using Backend.Entidades.Response;
using Backend.Entidades;
using Backend.Utilitarios;
using System.Web.Configuration;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text.Json;

namespace Backend.Logica
{

    public class Logica_Juego
    {

        public String url = "https://api.rawg.io/api/games?key=6bc63916d1ad47b6b887c04d145284f1";//URL del API externa
        JsonSerializerOptions options = new JsonSerializerOptions {
            PropertyNameCaseInsensitive = true
        };

        public async void ObtenerJuegosAPI() { 
            
            HttpClient httpClient = new HttpClient();

            var response = await httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {

                var content = await response.Content.ReadAsStringAsync();
                var juegos = JsonConvert.DeserializeObject<List<Juego>>(content);

            }
            else {
            }

        }

        /*public async ResObtenerListaJuegos obtenerListaJuegos(ReqObtenerListaJuegos req)
        {

            ResObtenerListaJuegos res = new ResObtenerListaJuegos();

            res.listDeErrores = new List<string>();

            try
            {
                HttpClient httpClient = new HttpClient();

                var response = await httpClient.GetAsync(url);
                
                if (response.IsSuccessStatusCode) {

                    var content = await response.Content.ReadAsStringAsync();

                    //ListaJuegos listaJuegos = JsonSerializer.Deserialize<ListaJuegos>(content, options);
                    ListaJuegos listaJuegos = JsonConvert.DeserializeObject<ListaJuegos>(content);

                    //foreach que recorra todos los datos que trae el API
                    //foreach () { }
                }

                if (req == null)
                {
                    res.listDeErrores.Add("Request es nulo");
                    res.result = false;
                }
                else
                {
                    conexionLinqDataContext conexion = new conexionLinqDataContext();
                    List<ObtenerListaJuegosResult> listaJuegoComplejo = new List<ObtenerListaJuegosResult>();
                    listaJuegoComplejo = conexion.ObtenerListaJuegos().ToList();
                    res.ListaJuego = Factory.factoryListaJuegos(listaJuegoComplejo);
                    res.result = true;
                }
            }
            catch (Exception e)
            {
                res.listDeErrores.Add("Error, no se pudieron traer los juegos : " + e.StackTrace);
                res.result = false;
            }

            return res;
        }*/
        
        public ResValidarCodigo validarCodigo(ReqValidarCodigo req)
        {
            ResValidarCodigo res = new ResValidarCodigo();

            try {

                if (req == null)
                {
                    res.listDeErrores.Add("Request es nulo");
                    res.result = false;
                }
                else {
                    if (String.IsNullOrEmpty(req.codigo)) {
                        res.listDeErrores.Add("Codigo de descuento vacío");
                        res.result = false;
                    }
                    if (!res.listDeErrores.Any()) {

                        conexionLinqDataContext conexion = new conexionLinqDataContext();
                        ValidarCodigoResult codigoComplejo = (ValidarCodigoResult)conexion.ValidarCodigo(req.codigo);                        
                        res.codigo = Factory.factoryCodigo(codigoComplejo);
                    }
                }
            } catch (Exception e) {
                res.listDeErrores.Add("Error no se pudo validar el código: " + e);
                res.result = false;
            }

            return res;
        }
    }
}