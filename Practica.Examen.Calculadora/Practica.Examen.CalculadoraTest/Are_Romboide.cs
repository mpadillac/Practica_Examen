using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Practica.Examen.CalculadoraTest
{
    [TestClass]
    public class Are_Romboide
    {
        [TestMethod]
        public void Area_Romboide()
        {
            // preparación del escenario
            var mibbase = 3.0;
            var mialtura = 7.0;
            var miValorEsperado = 21.0;
            var miValorReal = 0.0;

            // invocamos el método
            // para invocar dinámicamente al método
            var elServicio = new CalculadoraServicio.Logica.Servicio.Service1();
            miValorReal = elServicio.Area_Romboide(mibbase, mialtura);

            // verificar el resultado obtenido
            Assert.AreEqual(miValorEsperado, miValorReal);

        }
    }
}
