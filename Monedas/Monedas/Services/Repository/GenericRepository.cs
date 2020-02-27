using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Monedas.Domain.Context;

namespace Monedas.Services.Repository
{
    public class GenericRepository<T>:IGenericRepository<T> where T : class
    {
        public MonedasContext _dbContext = null;
        public DbSet<T> Table = null;

        public GenericRepository()
        {
            _dbContext = new MonedasContext();
            Table = _dbContext.Set<T>();
        }

        public GenericRepository(MonedasContext context)
        {
            _dbContext = context;
            Table = _dbContext.Set<T>();
        }

        public async Task Insert(List<T> lista)
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

        public async Task<IEnumerable<T>> FindAll()
        {
            return await Table.ToListAsync().ConfigureAwait(false);
        }

       
    }
}