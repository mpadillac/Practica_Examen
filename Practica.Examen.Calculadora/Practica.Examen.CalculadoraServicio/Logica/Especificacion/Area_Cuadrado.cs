using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica.Examen.CalculadoraServicio.Logica.Especificacion
{
    public class Area_Cuadrado
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="lado">valor del lado del cuadrado</param>
        /// <returns>valor del área del cuadrado</returns>
        public double Are_Cuadrado(double lado)
        {
            var laAccion = new Practica.Examen.CalculadoraServicio.Logica.Accion.Area_Cuadrado();
            double elResultado = laAccion.Are_Cuadrado(lado);
            return elResultado;
        }
    }
}