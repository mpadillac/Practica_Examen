using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica.Examen.CalculadoraServicio.Logica.Validacion
{
    public class Peri_Rombo
    {
        public bool LosOperadoresSonCorrectos(double lado)
        {
            bool elResultado = true;
            // valido que el lado sea positivo

            elResultado = !(lado <= 0);
            return elResultado;
        }
    }
}