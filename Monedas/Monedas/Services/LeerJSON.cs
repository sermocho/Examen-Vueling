using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using Monedas.Cross_Cutting.Exception;
using Newtonsoft.Json;

namespace Monedas.Services
{
    public class LeerJSON<T>
    {
        public List<T> lista;
        public List<T> GetDataJSON(string ruta)
        {

            using (var client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = client.GetAsync(ruta).Result;
                    string contenido = response.Content.ReadAsStringAsync().Result;
                    lista = JsonConvert.DeserializeObject<List<T>>(contenido);
                }

                catch(Exception ex)
                {
                    throw new FactoryException("Error al leer JSON", ex);
                }
            }

            return lista;
        }
    }
}