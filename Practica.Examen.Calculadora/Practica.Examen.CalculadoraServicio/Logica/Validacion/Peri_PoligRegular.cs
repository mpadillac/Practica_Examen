using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica.Examen.CalculadoraServicio.Logica.Validacion
{
    public class Peri_PoligRegular
    {
        public bool LosOperadoresSonCorrectos(double lado, int cant_lados)
        {
            bool elResultado = true;
            // valido que el ancho y largo sean positivos

            elResultado = !(lado <= 0 || cant_lados <= 4);
            return elResultado;
        }
    }
}