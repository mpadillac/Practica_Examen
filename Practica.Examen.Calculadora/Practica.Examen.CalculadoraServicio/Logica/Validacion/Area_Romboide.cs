using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica.Examen.CalculadoraServicio.Logica.Validacion
{
    public class Area_Romboide
    {
        public bool LosOperadoresSonCorrectos(double bbase, double altura)
        {
            bool elResultado = true;
            // valido que el lado sean positivos

            elResultado = !(bbase <= 0 || altura <= 0);
            
            return elResultado;
        }
    }
}