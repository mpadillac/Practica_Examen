using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica.Examen.CalculadoraServicio.Logica.Especificacion
{
    public class Vol_Esfera
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="radio">valor del radio de la esfera</param>
        /// <returns>regresa el valor del volumen de la esfera</returns>
        public double Volu_Esfera(double radio)
        {
            var laAccion = new Practica.Examen.CalculadoraServicio.Logica.Accion.Vol_Esfera();
            double elResultado = laAccion.Volumen_esfera(radio);
            return elResultado;
        }
    }
}