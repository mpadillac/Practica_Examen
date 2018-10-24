using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Practica.Examen.CalculadoraTest
{
    [TestClass]
    public class Vol_Cilindro
    {
        [TestMethod]
        public void Volu_Cilindro()
        {
            // preparación del escenario
            var miradio = 4.0;
            var mialtura = 6.0;
            var miValorEsperado = 301;
            var miValorReal = 0.0;

            // invocamos el método
            // para invocar dinámicamente al método
            var elServicio = new CalculadoraServicio.Logica.Servicio.Service1();
            miValorReal = elServicio.Volu_Cilindro(miradio, mialtura);

            // verificar el resultado obtenido
            Assert.AreEqual(miValorEsperado, miValorReal);

        }
    }
}
