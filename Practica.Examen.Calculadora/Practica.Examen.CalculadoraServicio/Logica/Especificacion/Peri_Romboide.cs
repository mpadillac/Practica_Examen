using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica.Examen.CalculadoraServicio.Logica.Especificacion
{
    public class Peri_Romboide
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="largo">valor del largo del romboide</param>
        /// <param name="ancho">valor del ancho del romboide</param>
        /// <returns>el valor del perímetro del romboide</returns>
        public double Perim_Romboide(double largo, double ancho)
        {
            var laAccion = new Practica.Examen.CalculadoraServicio.Logica.Accion.Peri_Romboide();
            double elResultado = laAccion.Perim_Romboide(largo, ancho);
            return elResultado;
        }
    }
}