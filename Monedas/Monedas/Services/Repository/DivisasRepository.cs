using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI.WebControls;
using Monedas.Domain.Context;
using Monedas.Domain.Models;

namespace Monedas.Services.Repository
{
    public class DivisasRepository:IDivisasRepository
    {
        private readonly MonedasContext _dbContext;
        private MonedasContext _getContext;
        public DbSet<Divisas> Table ;
        public string ruta = "http://quiet-stone-2094.herokuapp.com/rates.json";

        public async Task Insert(List<Divisas> lista)
        {
            EstadoWB estado=new EstadoWB();

            if (estado.ComprobarEstadoWB(ruta))
            {
                foreach (var item in lista)
                {
                    Table.Add(item);
                }
                await _dbContext.SaveChangesAsync().ConfigureAwait(false);
            }

           
        }

        public async Task All_Delete()
        {
            Table.RemoveRange(null);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Divisas>> FindAll()
        {
            return await Table.ToListAsync().ConfigureAwait(false);
        }


        MonedasContext IDivisasRepository.GetContext
        {
            get => _getContext;
            set => _getContext = value;
        }
    }
}