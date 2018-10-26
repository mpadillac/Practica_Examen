using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica.Examen.CalculadoraServicio.Logica.Validacion
{
    public class Vol_Piram_Poligonal
    {
        public bool LosOperadoresSonCorrectos(double apotema, double cant_lados, double altura, double long_lado)
        {
            bool elResultado = true;
            // valido que el ancho y largo sean positivos

            elResultado = !(apotema <= 0 || cant_lados <= 0 || altura <= 0 || long_lado <= 0);
            return elResultado;
        }
    }
}