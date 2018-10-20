using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Practica.Examen.CalculadoraTest
{
    [TestClass]
    public class Are_Rombo
    {
        [TestMethod]
        public void Area_Rombo()
        {
            // preparación del escenario
            var midiagonalmayor = 8.0;
            var midiagonalmenor = 6.0;
            var miValorEsperado = 24.0;
            var miValorReal = 0.0;

            // invocamos el método
            // para invocar dinámicamente al método
            var elServicio = new CalculadoraServicio.Logica.Servicio.Service1();
            miValorReal = elServicio.Area_Rombo(midiagonalmayor, midiagonalmenor);

            // verificar el resultado obtenido
            Assert.AreEqual(miValorEsperado, miValorReal);

        }
    }
}
