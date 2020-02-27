using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Monedas.Domain.Models;

namespace Monedas.Services.Factory
{
    public class DivisasFactory:IDivisasFactory
    {

        public Divisas Create(string from, string to, string rate)
        {
            Divisas divisas=new Divisas(from,to,rate);
            return divisas;
        }
    }
}