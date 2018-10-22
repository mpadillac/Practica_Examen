using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica.Examen.CalculadoraServicio.Logica.Especificacion
{
    public class Area_Triangulo
    {/// <summary>
    /// 
    /// </summary>
    /// <param name="ladoa">valor del lado a del triángulo</param>
    /// <param name="ladob">valor del lado b del triángulo</param>
    /// <param name="ladoc">valor del lado c del triángulo</param>
    /// <returns>valor del área del triángulo</returns>
        public double Are_Triangulo(double ladoa, double ladob, double ladoc)
        {
            
            var laAccion = new Practica.Examen.CalculadoraServicio.Logica.Accion.Area_Triangulo();
            double elResultado = laAccion.Are_Triangulo(ladoa, ladob, ladoc);
            return elResultado;
        }
    }
}