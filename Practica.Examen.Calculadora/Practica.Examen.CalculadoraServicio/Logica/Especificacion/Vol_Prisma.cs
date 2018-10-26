using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica.Examen.CalculadoraServicio.Logica.Especificacion
{
    public class Vol_Prisma
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="arebase">valor del área de la base del prisma</param>
        /// <param name="altura">valor de la altura del prisma</param>
        /// <returns>valor del volumen del prisma</returns>
        public double Volu_Prisma(double arebase, double altura)
        {
            var laAccion = new Practica.Examen.CalculadoraServicio.Logica.Accion.Vol_Prisma();
            double elResultado = laAccion.Volumen_Prisma(arebase, altura);
            return elResultado;
        }
    }
}