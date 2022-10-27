using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Calculadora.Test
{
    [TestClass]
    public class CalculadoraTest
    {
        [TestMethod]
        public void Somar()
        {
            Assert.AreEqual(20, Calculadora.Somar(10, 10));
        }

        [TestMethod]
        public void Subtrair()
        {
            Assert.AreEqual(0, Calculadora.Subtrair(10, 10));
        }

        [TestMethod]
        public void Multiplicar()
        {
            Assert.AreEqual(100, Calculadora.Multiplicar(10, 10));
        }

        [TestMethod]
        public void Dividir()
        {
            Assert.AreEqual(5, Calculadora.Dividir(10, 2));
        }
    }
}
