using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using Monedas.Cross_Cutting.Exception;

namespace Monedas.Services
{
    public class EstadoWB
    {
    
        public bool ComprobarEstadoWB(string ruta)
        {
            try
            {
                var myRequest = (HttpWebRequest)WebRequest.Create(ruta);

                var response = (HttpWebResponse)myRequest.GetResponse();

                if (response.StatusCode == HttpStatusCode.OK)
                    return true;

                else
                    return false;
            }

            catch (Exception ex)
            {
                throw new ConectionException("Error al conectar con WEB Service", ex);
            }
        }
        
    }
}