using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica.Examen.CalculadoraServicio.Logica.Validacion
{
    public class Vol_Esfera
    {
        public bool LosOperadoresSonCorrectos(double radio)
        {
            bool elResultado = true;
            // valido que el valor sea positivo

            elResultado = !(radio <= 0);
            return elResultado;
        }
    }
}