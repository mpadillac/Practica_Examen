using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica.Examen.CalculadoraServicio.Logica.Especificacion
{
    public class Peri_Trapecio
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ladoa">valor del lado a</param>
        /// <param name="ladob">valor del lado b</param>
        /// <param name="ladoc">valor del lado c</param>
        /// <param name="ladod">valor del lado d</param>
        /// <returns>valor del perímetro del trapecio</returns>
        public double Perim_Trapecio(double ladoa, double ladob, double ladoc, double ladod)
        {
            var laAccion = new Practica.Examen.CalculadoraServicio.Logica.Accion.Peri_Trapecio();
            double elResultado = laAccion.Perim_Trapecio(ladoa, ladob, ladoc, ladod);
            return elResultado;
        }
    }
}