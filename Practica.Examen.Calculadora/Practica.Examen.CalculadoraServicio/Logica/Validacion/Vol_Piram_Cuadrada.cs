using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica.Examen.CalculadoraServicio.Logica.Validacion
{
    public class Vol_Piram_Cuadrada
    {
        public bool LosOperadoresSonCorrectos(double lbase, double altura)
        {
            bool elResultado = true;
            // valido que los valores sean positivos

            elResultado = !(lbase <= 0 || altura <= 0);
            return elResultado;
        }
    }
}