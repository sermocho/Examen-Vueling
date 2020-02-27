using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Monedas.Domain.Models;
using Monedas.Models.Domain;
using Monedas.Services.Repository;

namespace Monedas.Services.Factory
{
    public class ListaDivisasFactory:IListaDivisasFactory
    {
        private DivisasRepository _repository;

        public List<Divisas> CrearLista(string ruta)
        {
            var leer=new LeerJSON<Divisas>();
            var listaDivisas = leer.GetDataJSON(_repository.ruta);
            return listaDivisas;
        }
    }
}