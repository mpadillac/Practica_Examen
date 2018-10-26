using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica.Examen.CalculadoraServicio.Logica.Especificacion
{
    public class Vol_Cubo
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="arista">valor de la arista del cubo</param>
        /// <returns>el valor del volumen del cubo</returns>
        public double Volu_Cubo(double arista)
        {
            var laAccion = new Practica.Examen.CalculadoraServicio.Logica.Accion.Vol_Cubo();
            double elResultado = laAccion.Volumen_Cubo(arista);
            return elResultado;
        }
    }
}