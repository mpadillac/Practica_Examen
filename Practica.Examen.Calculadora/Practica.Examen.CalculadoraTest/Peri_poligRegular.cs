using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Practica.Examen.CalculadoraTest
{
    [TestClass]
    public class Peri_PoligRegular
    {
        [TestMethod]
        public void Peri_PolRegular()
        {
            // preparación del escenario
            var milado = 3.0;
            var micant_lados = 5;
            var miValorEsperado = 15.0;
            var miValorReal = 0.0;

            // invocamos el método
            // para invocar dinámicamente al método
            var elServicio = new CalculadoraServicio.Logica.Servicio.Service1();
            miValorReal = elServicio.Peri_PoligRegular(milado, micant_lados);

            // verificar el resultado obtenido
            Assert.AreEqual(miValorEsperado, miValorReal);

        }
    }
}
