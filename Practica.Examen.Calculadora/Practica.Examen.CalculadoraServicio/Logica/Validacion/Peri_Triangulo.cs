using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica.Examen.CalculadoraServicio.Logica.Validacion
{
    public class Peri_Triangulo
    {
        public bool LosOperadoresSonCorrectos(double ladoa, double ladob, double ladoc)
        {
            bool elResultado = true;
            // valido que los lados sean positivos y que dos de los lados pequeños no sean más grandes que el mayor
            var A = ladoa + ladob;
            var B = ladoa + ladoc;
            var C = ladob + ladoc;
            elResultado = !(ladoa <= 0 || ladob <= 0 || ladoc <= 0);
            elResultado = !(ladoa <= C && ladob <= B && ladoc <= A);
            
            return elResultado;
        }
    }
}