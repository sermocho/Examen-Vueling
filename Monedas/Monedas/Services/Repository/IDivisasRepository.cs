using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monedas.Domain.Context;
using Monedas.Domain.Models;

namespace Monedas.Services.Repository
{
    public interface IDivisasRepository:IGenericRepository<Divisas>
    {
        
        MonedasContext GetContext { get; set; }
        
    }
}
