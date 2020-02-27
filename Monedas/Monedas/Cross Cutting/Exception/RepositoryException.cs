using System;

namespace Monedas.Cross_Cutting.Exception
{
    public class RepositoryException : System.Exception
    {
        public RepositoryException(string message, System.Exception innerException) : base(message, innerException)
        {
        }
    }
}