using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Practica.Examen.CalculadoraTest
{
    [TestClass]
    public class Are_Rectangulo
    {
        [TestMethod]
        public void Area_Recta()
        {
            // preparación del escenario
            var miancho = 3.0;
            var milargo = 5.0;
            var miValorEsperado = 15.0;
            var miValorReal = 0.0;

            // invocamos el método
            // para invocar dinámicamente al método
            var elServicio = new CalculadoraServicio.Logica.Servicio.Service1();
            miValorReal = elServicio.Area_Rectangulo(miancho, milargo);

            // verificar el resultado obtenido
            Assert.AreEqual(miValorEsperado, miValorReal);

        }
    }
}
