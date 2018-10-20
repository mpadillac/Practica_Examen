using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica.Examen.CalculadoraServicio.Logica.Validacion
{
    public class Peri_Rectangulo
    {
        public bool LosOperadoresSonCorrectos(double ancho, double largo)
        {
            bool elResultado = true;
            // valido que el ancho y largo sean positivos

            elResultado = !(ancho <= 0 && largo <= 0);
            return elResultado;
        }
    }
}