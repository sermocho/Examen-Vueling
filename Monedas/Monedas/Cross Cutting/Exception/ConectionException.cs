using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Monedas.Cross_Cutting.Exception
{
    public class ConectionException : System.Exception
    {
        public ConectionException(string message, System.Exception innerException) : base(message, innerException)
        {

        }
    }
}