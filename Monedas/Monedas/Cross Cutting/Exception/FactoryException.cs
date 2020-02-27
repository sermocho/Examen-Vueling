using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Monedas.Cross_Cutting.Exception
{
    public class FactoryException : System.Exception
    {
        public FactoryException(string message, System.Exception innerException) : base(message, innerException)
        {
        }
    }
}