using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica.Examen.CalculadoraServicio.Logica.Especificacion
{
    public class Vol_Cilindro
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="radio">valor del radio del cilindro</param>
        /// <param name="altura">valor de la altura del cilindro</param>
        /// <returns>valor del volumen del cilindro</returns>
        public double Volu_Cilindro(double radio, double altura)
        {
            var laAccion = new Practica.Examen.CalculadoraServicio.Logica.Accion.Vol_Cilindro();
            double elResultado = laAccion.Volumen_Cilindro(radio, altura);
            return elResultado;
        }
    }
}