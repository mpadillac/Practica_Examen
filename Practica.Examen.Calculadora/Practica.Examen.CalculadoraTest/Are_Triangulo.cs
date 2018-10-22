using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Practica.Examen.CalculadoraTest
{
    [TestClass]
    public class Are_Triangulo
    {
        [TestMethod]
        public void Area_Triangulo()
        {
            // preparacin del escenario
            var miladoa = 12.0;
            var miladob = 10.0;
            var miladoc = 20.0;
            var miValorEsperado = 45;
            var miValorReal = 0.0;

            // invocamos el mtodo
            // para invocar dinmicamente al mtodo
            var elServicio = new CalculadoraServicio.Logica.Servicio.Service1();
            miValorReal = elServicio.Area_Triangulo(miladoa, miladob, miladoc);

            // verificar el resultado obtenido
            Assert.AreEqual(miValorEsperado, miValorReal);

        }
    }
}
