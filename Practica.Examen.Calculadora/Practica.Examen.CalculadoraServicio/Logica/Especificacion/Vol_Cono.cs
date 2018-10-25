using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica.Examen.CalculadoraServicio.Logica.Especificacion
{
    public class Vol_Cono
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="radio">valor del radio del cono</param>
        /// <param name="altura">valor de la altura del cono</param>
        /// <returns>valor del volumen del cono</returns>
        public double Volu_Cono(double radio, double altura)
        {
            var laAccion = new Practica.Examen.CalculadoraServicio.Logica.Accion.Vol_Cono();
            double elResultado = laAccion.Volumen_Cono(radio, altura);
            return elResultado;
        }
    }
}