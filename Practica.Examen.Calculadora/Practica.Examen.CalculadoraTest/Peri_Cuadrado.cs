using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practica.Examen.CalculadoraServicio;

namespace Practica.Examen.CalculadoraTest
{
    [TestClass]
    public class Peri_Cuadrado
    {
        [TestMethod]
        public void Peri_Cuadra()
        {
            // preparación del escenario
            var milado = 4.0;
            var miValorEsperado = 16.0;
            var miValorReal = 0.0;

            // invocamos el método
            // para invocar dinámicamente al método
            var elServicio = new CalculadoraServicio.Logica.Servicio.Service1();
            miValorReal = elServicio.Peri_Cuadrado(milado);

            // verificar el resultado obtenido
            Assert.AreEqual(miValorEsperado, miValorReal);

        }
    }
}
