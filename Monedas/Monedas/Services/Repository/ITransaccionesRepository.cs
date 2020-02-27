using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monedas.Domain.Context;
using Monedas.Models.Domain;

namespace Monedas.Services.Repository
{
    public interface ITransaccionesRepository:IGenericRepository<Transacciones>
    {
        MonedasContext GetContext { get; set; }
    }
}
