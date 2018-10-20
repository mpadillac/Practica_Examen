using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Practica.Examen.CalculadoraTest
{
    [TestClass]
    public class Peri_Trapecio
    {
        [TestMethod]
        public void Perim_Trapecio()
        {
            // preparación del escenario
            var miladoa = 8.0;
            var miladob = 5.0;
            var miladoc = 7.0;
            var miladod = 9.0;
            var miValorEsperado = 29.0;
            var miValorReal = 0.0;

            // invocamos el método
            // para invocar dinámicamente al método
            var elServicio = new CalculadoraServicio.Logica.Servicio.Service1();
            miValorReal = elServicio.Peri_Trapecio(miladoa, miladob, miladoc, miladod);

            // verificar el resultado obtenido
            Assert.AreEqual(miValorEsperado, miValorReal);

        }
    }
}
