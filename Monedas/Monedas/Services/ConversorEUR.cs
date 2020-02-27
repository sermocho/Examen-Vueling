using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Windows.Forms.VisualStyles;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using Monedas.Domain.Models;
using Monedas.Models.Domain;

namespace Monedas.Services
{
    public class ConversorEUR
    {
        private List<Divisas> _lista;
        public ConversorEUR(List<Divisas> lista)
        {
            _lista = lista;
        }

        public void Convertir(List<Divisas> lista)
        {
            List<DivisasEUR> listaEUR;
            
            var sin_cambio = from s in _lista
                where s.to == "EUR"
                select s;

           //var doble_cambio=from d in _lista group 

            foreach (var itemEuros  in lista)
            {
                foreach (var item in sin_cambio)
                {
                    itemEuros.from = item.from;
                    itemEuros.rate = item.rate;
                }

            }

            
                
            

        }
    }
}