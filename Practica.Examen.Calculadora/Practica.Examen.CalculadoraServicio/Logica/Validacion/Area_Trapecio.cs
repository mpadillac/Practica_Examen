using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica.Examen.CalculadoraServicio.Logica.Validacion
{
    public class Area_Trapecio
    {
        public bool LosOperadoresSonCorrectos(double base_mayor, double base_menor, double altura)
        {
            bool elResultado = true;
            // valido que el ancho y largo sean positivos

            elResultado = !(base_mayor <= 0 || base_menor <= 0 || altura <= 0);
            return elResultado;
        }
    }
}