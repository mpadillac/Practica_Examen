using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Practica.Examen.CalculadoraTest
{
    [TestClass]
    public class Are_Trapecio
    {
        [TestMethod]
        public void Area_Trapecio()
        {
            // preparación del escenario
            var mibasemayor = 3.0;
            var mibasemenor = 5.0;
            var mialtura = 2.0;
            var miValorEsperado = 8.0;
            var miValorReal = 0.0;

            // invocamos el método
            // para invocar dinámicamente al método
            var elServicio = new CalculadoraServicio.Logica.Servicio.Service1();
            miValorReal = elServicio.Area_Trapecio(mibasemayor, mibasemenor, mialtura);

            // verificar el resultado obtenido
            Assert.AreEqual(miValorEsperado, miValorReal);

        }
    }
}
