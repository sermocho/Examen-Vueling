using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using Monedas.Domain.Models;
using Monedas.Models.Domain;

namespace Monedas.Domain.Context
{
    public class MonedasContext:DbContext
    {
        public MonedasContext() : base("MonedasContext")
        {
        }

        public DbSet<Divisas> Divisas { get; set; }
        public DbSet<Transacciones> Transaccioneses { get; set; }
    }
}