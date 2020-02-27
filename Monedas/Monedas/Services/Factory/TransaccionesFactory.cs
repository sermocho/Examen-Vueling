using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Monedas.Domain.Models;
using Monedas.Models.Domain;

namespace Monedas.Services.Factory
{
    public class TransaccionesFactory :ITransaccionesFactory
    {

        public Transacciones Create(string from, string to, string rate)
        {
            Transacciones transacciones = new Transacciones(from, to, rate);
            return transacciones;
        }
    }
}