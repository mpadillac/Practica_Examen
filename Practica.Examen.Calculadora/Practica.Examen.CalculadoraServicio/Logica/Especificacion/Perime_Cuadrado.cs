using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica.Examen.CalculadoraServicio.Logica.Especificacion
{
    public class Perime_Cuadrado
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="valor del lado del cuadrado"></param>
        /// <returns></returns>

        public double Peri_Cuadrado(double lado)
        {
            var laAccion = new Practica.Examen.CalculadoraServicio.Logica.Accion.Perime_Cuadrado();
            double elResultado = laAccion.Peri_Cuadrado(lado);
            return elResultado;
        }
    }
}