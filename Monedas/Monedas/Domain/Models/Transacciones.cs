using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Monedas.Models.Domain
{
    public class Transacciones
    {
        public int Id { get; set; }
        public string sku { get; set; }
        public string amount { get; set; }
        public string currency { get; set; }

        public Transacciones(string _sku,string _amount,string _currency)
        {
            this.sku = _sku;
            this.amount = _amount;
            this.currency = _currency;
        }
       
    }
}