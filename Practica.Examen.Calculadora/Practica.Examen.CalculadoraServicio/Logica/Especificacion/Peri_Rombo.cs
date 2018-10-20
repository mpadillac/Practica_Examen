using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica.Examen.CalculadoraServicio.Logica.Especificacion
{
    public class Peri_Rombo
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="lado">valor del lado del rombo</param>
        /// <returns>el valor del perímetro del rombo</returns>
        public double Perim_Rombo(double lado)
        {
            var laAccion = new Practica.Examen.CalculadoraServicio.Logica.Accion.Peri_Rombo();
            double elResultado = laAccion.Perim_Rombo(lado);
            return elResultado;
        }
    }
}