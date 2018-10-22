using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica.Examen.CalculadoraServicio.Logica.Especificacion
{
    public class Peri_Triangulo
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ladoa">valor del lado a del triángulo</param>
        /// <param name="ladob">valor del lado b del triángulo</param>
        /// <param name="ladoc">valor del lado b del triángulo</param>
        /// <returns>el valor del perímetro del triángulo</returns>
        public double Perim_Triangulo(double ladoa, double ladob, double ladoc)
        {
            var laAccion = new Practica.Examen.CalculadoraServicio.Logica.Accion.Peri_Triangulo();
            double elResultado = laAccion.Perim_Triangulo(ladoa, ladob, ladoc);
            return elResultado;
        }
    }
}