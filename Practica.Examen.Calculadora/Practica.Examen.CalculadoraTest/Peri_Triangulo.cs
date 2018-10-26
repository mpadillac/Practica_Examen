using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Practica.Examen.CalculadoraTest
{
    [TestClass]
    public class Peri_Triangulo
    {
       
            [TestMethod]
        public void Perim_Triangulo()
        {
            // preparación del escenario
            var miladoa = 7.0;
            var miladob = 10.0;
            var miladoc = 16.0;
            var miValorEsperado = 33.0;
            var miValorReal = 0.0;

            // invocamos el método
            // para invocar dinámicamente al método
            var elServicio = new CalculadoraServicio.Logica.Servicio.Service1();
            miValorReal = elServicio.Peri_Triangulo(miladoa, miladob, miladoc);

            // verificar el resultado obtenido
            Assert.AreEqual(miValorEsperado, miValorReal);

        }
    }
    
}
