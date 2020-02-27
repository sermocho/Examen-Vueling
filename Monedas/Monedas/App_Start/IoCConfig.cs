using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using Monedas.Domain.Context;
using Monedas.Domain.Models;
using Monedas.Models.Domain;
using Monedas.Services.Repository;

namespace Monedas.App_Start
{
    public class IoCConfig
    {
        public static void RegistrarControllers(ContainerBuilder builder)
        {
            builder.RegisterControllers
                (Assembly.GetExecutingAssembly());
        }

        public static void RegistrarRepos(ContainerBuilder builder)
        {
            builder.RegisterType<DivisasRepository>()
                .As<IDivisasRepository>().InstancePerRequest();
            builder.RegisterType<TransaccionesRepository>()
                .As<ITransaccionesRepository>().InstancePerRequest();
            builder.RegisterType<GenericRepository<Divisas>>()
                .As<IGenericRepository<Divisas>>().InstancePerRequest();
            builder.RegisterType<GenericRepository<Transacciones>>()
                .As<IGenericRepository<Transacciones>>().InstancePerRequest();
        }

        public static void RegistrarClases(ContainerBuilder builder)
        {
            builder.Register(z => new MonedasContext()).InstancePerRequest();
        }

        public static void Configure()
        {
            var builder = new ContainerBuilder();

            RegistrarControllers(builder);
            RegistrarRepos(builder);
            RegistrarClases(builder);

            var contenedor = builder.Build();

            DependencyResolver.SetResolver
                (new AutofacDependencyResolver(contenedor));
        }
    }

}
