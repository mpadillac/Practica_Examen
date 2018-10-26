using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Practica.Examen.CalculadoraTest
{
    [TestClass]
    public class Vol_Piram_Cuadrada
    {
        [TestMethod]
        public void Volu_Pirami_Cuadrada()
        {
            // preparación del escenario
            var milbase = 4.0;
            var mialtura = 6.0;
            var miValorEsperado = 32;
            var miValorReal = 0.0;

            // invocamos el método
            // para invocar dinámicamente al método
            var elServicio = new CalculadoraServicio.Logica.Servicio.Service1();
            miValorReal = elServicio.Volu_Piram_Cuadrada(milbase, mialtura);

            // verificar el resultado obtenido
            Assert.AreEqual(miValorEsperado, miValorReal);

        }
    }
}
