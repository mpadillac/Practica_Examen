using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Practica.Examen.CalculadoraTest
{
    [TestClass]
    public class Vol_Prisma
    {
        [TestMethod]
        public void Volu_Prisma()
        {
            // preparación del escenario
            var miarebase = 4.0;
            var mialtura = 5.0;
            var miValorEsperado = 20;
            var miValorReal = 0.0;

            // invocamos el método
            // para invocar dinámicamente al método
            var elServicio = new CalculadoraServicio.Logica.Servicio.Service1();
            miValorReal = elServicio.Volu_Prisma(miarebase, mialtura);

            // verificar el resultado obtenido
            Assert.AreEqual(miValorEsperado, miValorReal);

        }
    }
}
