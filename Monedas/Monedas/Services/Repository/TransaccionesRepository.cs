using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Monedas.Domain.Context;
using Monedas.Domain.Models;
using Monedas.Models.Domain;
using Monedas.Services.Factory;

namespace Monedas.Services.Repository
{
    public class TransaccionesRepository : ITransaccionesRepository
    {
        private readonly MonedasContext _dbContext;
        private MonedasContext _getContext;
        public DbSet<Transacciones> Table;
        public string ruta = "http://quiet-stone-2094.herokuapp.com/transactions.json";
        public async Task Insert(List<Transacciones> lista)
        {
            foreach (var item in lista)
            {
                Table.Add(item);
            }
            await _dbContext.SaveChangesAsync().ConfigureAwait(false);
        }


        public async Task All_Delete()
        {
            Table.RemoveRange(null);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Transacciones>> FindAll()
        {
            return await Table.ToListAsync().ConfigureAwait(false);
        }

        public async Task<IEnumerable<Transacciones>> VerporSku(List<Transacciones> listaTransacciones)
        {
            //var consulta = from t in listaTransacciones
            //    group t.sku by new {sku = t.sku}
            //    into s
            //    select new
            //    {
            //        Key = s.Key,
            //        amount = Convert.ToDecimal(s.amount)
            //    };
            return listaTransacciones;
        }

       


        MonedasContext ITransaccionesRepository.GetContext
        {
            get => _getContext;
            set => _getContext = value;
        }
    }
}