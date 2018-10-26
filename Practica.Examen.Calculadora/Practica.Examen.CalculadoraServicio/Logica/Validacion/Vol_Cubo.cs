using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica.Examen.CalculadoraServicio.Logica.Validacion
{
    public class Vol_Cubo
    {
        public bool LosOperadoresSonCorrectos(double arista)
        {
            bool elResultado = true;
            // valido que el valor sea positivo

            elResultado = !(arista <= 0);
            return elResultado;
        }
    }
}