using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica.Examen.CalculadoraServicio.Logica.Validacion
{
    public class Area_Rombo
    {
        public bool LosOperadoresSonCorrectos(double Diag_mayor, double Diag_menor)
        {
            bool elResultado = true;
            // valido que el ancho y largo sean positivos

            elResultado = !(Diag_mayor <= 0 && Diag_menor <= 0);
            return elResultado;
        }
    }
}