using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica.Examen.CalculadoraServicio.Logica.Especificacion
{
    public class Area_Rombo
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Diag_mayor">valor de la diagonal mayor</param>
        /// <param name="Diag_menor">valor de la diagonal menor</param>
        /// <returns>valor del área del rombo</returns>
        public double Area_Romb(double Diag_mayor, double Diag_menor)
        {
            var laAccion = new Practica.Examen.CalculadoraServicio.Logica.Accion.Area_Rombo();
            double elResultado = laAccion.Are_Rombo(Diag_mayor, Diag_menor);
            return elResultado;
        }
    }
}