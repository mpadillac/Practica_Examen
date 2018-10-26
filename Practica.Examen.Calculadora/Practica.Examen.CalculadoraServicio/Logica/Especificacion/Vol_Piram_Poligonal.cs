using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica.Examen.CalculadoraServicio.Logica.Especificacion
{
    public class Vol_Piram_Poligonal
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="apotema">valor de la apotema de la pirámide</param>
        /// <param name="cant_lados">cantidad de lados de la pirámide</param>
        /// <param name="altura">valor de la altura de la pirámide</param>
        /// <param name="long_lado">valor de la longitud del laldo de la pirámide</param>
        /// <returns>valor del volumen de la pirámide</returns>
        public double Volu_Piram_Poligonal(double apotema, double cant_lados, double altura, double long_lado)
        {
            var laAccion = new Practica.Examen.CalculadoraServicio.Logica.Accion.Vol_Piram_Poligonal();
            double elResultado = laAccion.Volu_Piram_Poligonal(apotema, cant_lados, altura, long_lado);
            return elResultado;
        }
    }
}