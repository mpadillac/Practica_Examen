using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica.Examen.CalculadoraServicio.Logica.Especificacion
{
    public class Peri_Rectangulo
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ancho">valor del ancho del rectángulo</param>
        /// <param name="largo">valor del largo del rectángulo</param>
        /// <returns>valor del perímetro del rectángulo</returns>
        public double Peri_Rectangu(double ancho, double largo)
        {
            var laAccion = new Practica.Examen.CalculadoraServicio.Logica.Accion.Peri_Rectangulo();
            double elResultado = laAccion.Perim_Rectangulo(ancho,largo);
            return elResultado;
        }
    }
}