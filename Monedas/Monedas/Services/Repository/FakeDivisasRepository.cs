using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Monedas.Domain.Context;
using Monedas.Domain.Models;

namespace Monedas.Services.Repository
{
    public class FakeDivisasRepository:IDivisasRepository
    {
        public Task Insert(List<Divisas> item)
        {
            throw new NotImplementedException();
        }

        public Task All_Delete()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Divisas>> FindAll()
        {
            throw new NotImplementedException();
        }

        public MonedasContext GetContext { get; set; }
    }
}