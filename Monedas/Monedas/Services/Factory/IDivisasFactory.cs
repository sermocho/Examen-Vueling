using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monedas.Domain.Models;

namespace Monedas.Services.Factory
{
    public interface IDivisasFactory
    {
        Divisas Create(string from, string to, string rate);
    }
}
