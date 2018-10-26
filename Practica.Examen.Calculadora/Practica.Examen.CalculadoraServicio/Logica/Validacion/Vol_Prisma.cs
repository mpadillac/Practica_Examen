using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica.Examen.CalculadoraServicio.Logica.Validacion
{
    public class Vol_Prisma
    {
        public bool LosOperadoresSonCorrectos(double arebase, double altura)
        {
            bool elResultado = true;
            // valido que los valores sean positivos

            elResultado = !(arebase <= 0 || altura <= 0);
            return elResultado;
        }
    }
}