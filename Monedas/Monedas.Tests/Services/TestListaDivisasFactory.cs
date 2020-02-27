using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monedas.Services.Factory;

namespace Monedas.Tests
{
    [TestClass]
    public class Test_ListaDivisasFactory
    {
        [TestMethod]
        public void Comprobar_que_no_es_nulo()
        {
            ListaDivisasFactory factory=new ListaDivisasFactory();
            var prueba=factory.CrearLista("http://quiet-stone-2094.herokuapp.com/transactions.json");
            Assert.IsNotNull(prueba);
        }
    }
}
