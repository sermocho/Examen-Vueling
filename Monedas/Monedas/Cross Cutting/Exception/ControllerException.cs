using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Monedas.Cross_Cutting.Exception
{
    public class ControllerException : System.Exception
    {
        public ControllerException(string message) : base(message)
        {

        }
    }
}