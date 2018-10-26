using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Practica.Examen.CalculadoraTest
{
    [TestClass]
    public class Vol_Piram_Poligonal
    {
        [TestMethod]
        public void Volu_Piram_Poligonal()
        {
            // preparación del escenario
            var miapotema = 8.0;
            var micant_lados = 6.0;
            var mialtura = 7.0;
            var milong_lado = 9.0;
            var miValorEsperado = 504.0;
            var miValorReal = 0.0;

            // invocamos el método
            // para invocar dinámicamente al método
            var elServicio = new CalculadoraServicio.Logica.Servicio.Service1();
            miValorReal = elServicio.Volu_Piram_Poligonal(miapotema, micant_lados, mialtura, milong_lado);

            // verificar el resultado obtenido
            Assert.AreEqual(miValorEsperado, miValorReal);

        }
    }
}
