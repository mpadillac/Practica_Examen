using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica.Examen.CalculadoraServicio.Logica.Validacion
{
    public class Peri_Trapecio
    {
        public bool LosOperadoresSonCorrectos(double ladoa, double ladob, double ladoc, double ladod)
        {
            bool elResultado = true;
            // valido que el ancho y largo sean positivos

            elResultado = !(ladoa <= 0 || ladob <= 0 || ladoc <= 0 || ladod <= 0);
            return elResultado;
        }
    }
}