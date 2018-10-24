using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Practica.Examen.CalculadoraTest
{
    [TestClass]
    public class Peri_Romboide
    {
        [TestMethod]
        public void Perim_Romboide()
        {
            // preparación del escenario
            var milargo = 7.0;
            var miancho = 3.0;
            var miValorEsperado = 20.0;
            var miValorReal = 0.0;

            // invocamos el método
            // para invocar dinámicamente al método
            var elServicio = new CalculadoraServicio.Logica.Servicio.Service1();
            miValorReal = elServicio.Peri_Romboide(milargo, miancho);

            // verificar el resultado obtenido
            Assert.AreEqual(miValorEsperado, miValorReal);

        }
    }
}
