using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monedas.Models.Domain;

namespace Monedas.Services.Factory
{
    interface ITransaccionesFactory
    {
        Transacciones Create(string sku, string amount, string rate);
    }
}
