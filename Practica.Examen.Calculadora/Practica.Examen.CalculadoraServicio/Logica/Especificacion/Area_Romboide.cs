using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica.Examen.CalculadoraServicio.Logica.Especificacion
{
    public class Area_Romboide
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="bbase">valor de la base del Romboide</param>
        /// <param name="altura">valor de la altura del Romboide</param>
        /// <returns>valor del área del Romboide</returns>
        public double Are_Romboide(double bbase, double altura)
        {
            var laAccion = new Practica.Examen.CalculadoraServicio.Logica.Accion.Area_Romboide();
            double elResultado = laAccion.Are_Romboide(bbase, altura);
            return elResultado;
        }
    }
}