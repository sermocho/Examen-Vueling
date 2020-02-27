using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monedas.Domain.Models;
using Monedas.Models.Domain;

namespace Monedas.Services.Factory
{
    interface IListaDivisasFactory
    {
        List<Divisas> CrearLista(string ruta);
    }
}
