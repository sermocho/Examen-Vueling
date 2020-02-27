using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monedas.Services;

namespace Monedas.Tests
{
   
    [TestClass]
    public class TestEstadoWB
    {
        [TestMethod]
        public void Check_ComprobarEstado_WB_DireccionCorrecta()
        {
            EstadoWB estado = new EstadoWB();

            string direccion = "http://quiet-stone-2094.herokuapp.com/transactions.json";


            bool correcto = estado.ComprobarEstadoWB(direccion);


            Assert.IsTrue(correcto);


        }

        public void Check_ComprobarEstado_WB2_Direccion_Vacia()
        {
            EstadoWB estado = new EstadoWB();

            string vacio = "";

            bool incorrecto = estado.ComprobarEstadoWB(vacio);

            Assert.IsFalse(incorrecto);


        }
    }
}
