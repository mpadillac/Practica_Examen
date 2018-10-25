using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica.Examen.CalculadoraServicio.Logica.Validacion
{
    public class Vol_Cono
    {
        public bool LosOperadoresSonCorrectos(double radio, double altura)
        {
            bool elResultado = true;
            // valido que los valores sean positivos

            elResultado = !(radio <= 0 || altura <= 0);
            return elResultado;
        }
    }
}