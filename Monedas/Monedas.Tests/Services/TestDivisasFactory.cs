using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monedas.Services.Factory;

namespace Monedas.Tests
{
    [TestClass]
    public class TestDivisasFactory
    {
        [TestMethod]
        public void Probar_Divisas_null()
        {
            string from = "EUR";
            string to = "USD";
            string rate = "0.8";

            DivisasFactory divisas=new DivisasFactory();
            var divisa=divisas.Create(from, to, rate);

            Assert.IsNotNull(divisa);
        }
    }
}
