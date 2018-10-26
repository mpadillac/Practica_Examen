using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica.Examen.CalculadoraServicio.Logica.Especificacion
{
    public class Vol_Piram_Cuadrada
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="lbase">valor del lado de la base de la pirámide cuadrada</param>
        /// <param name="altura">valor de la altura de la pirámide cuadrada</param>
        /// <returns>valor del volumen de la piámide cuadrada</returns>
        public double Volu_Piram_Cuadrada(double lbase, double altura)
        {
            var laAccion = new Practica.Examen.CalculadoraServicio.Logica.Accion.Vol_Piram_Cuadrada();
            double elResultado = laAccion.Volumen_Piram_Cuadrada(lbase, altura);
            return elResultado;
        }
    }
}