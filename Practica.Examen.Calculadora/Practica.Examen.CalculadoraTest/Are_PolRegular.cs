using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Practica.Examen.CalculadoraTest
{
    [TestClass]
    public class Are_PolRegular
    {
        [TestMethod]
        public void Area_PolRegular()
        {
            // preparación del escenario
            var milado = 3.0;
            var miapotema = 2.0;
            var micant_lados = 5;
            var miValorEsperado = 15.0;
            var miValorReal = 0.0;

            // invocamos el método
            // para invocar dinámicamente al método
            var elServicio = new CalculadoraServicio.Logica.Servicio.Service1();
            miValorReal = elServicio.Area_PoligRegular(milado, miapotema, micant_lados);

            // verificar el resultado obtenido
            Assert.AreEqual(miValorEsperado, miValorReal);

        }
    }
}
