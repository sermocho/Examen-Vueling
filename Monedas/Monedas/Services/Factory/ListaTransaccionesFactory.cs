using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Monedas.Domain.Models;
using Monedas.Models.Domain;
using Monedas.Services.Repository;

namespace Monedas.Services.Factory
{
    public class ListaTransaccionesFactory:IListaTransaccionesFactory
    {
        private TransaccionesRepository _repository;
        public List<Transacciones> CrearLista(string ruta)
        {
            var leer = new LeerJSON<Transacciones>();
            var listaTransacciones = leer.GetDataJSON(_repository.ruta);
            return listaTransacciones;
        }
    }
}