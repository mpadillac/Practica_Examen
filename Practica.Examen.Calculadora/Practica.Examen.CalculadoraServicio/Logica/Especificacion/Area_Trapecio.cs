using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica.Examen.CalculadoraServicio.Logica.Especificacion
{
    public class Area_Trapecio
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="base_mayor">valor de la base mayor</param>
        /// <param name="base_menor">valor de la base menor</param>
        /// <param name="altura">valor de la altura</param>
        /// <returns>valor del área del trapecio</returns>
        public double Are_Trapecio(double base_mayor, double base_menor, double altura)
        {
            var laAccion = new Practica.Examen.CalculadoraServicio.Logica.Accion.Area_Trapecio();
            double elResultado = laAccion.Are_Trapecio(base_mayor, base_menor, altura);
            return elResultado;
        }
    }
}