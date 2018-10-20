using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica.Examen.CalculadoraServicio.Logica.Especificacion
{
    public class Area_Rectangulo
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ancho">valor del ancho del rectángulo</param>
        /// <param name="largo">valor del largo delrectángulo</param>
        /// <returns>valor del área del rectángulo</returns>
        public double Area_Rectangu(double ancho, double largo)
        {
            var laAccion = new Practica.Examen.CalculadoraServicio.Logica.Accion.Area_Rectangulo();
            double elResultado = laAccion.Area_Rectangu(ancho, largo);
            return elResultado;
        }
    }
}