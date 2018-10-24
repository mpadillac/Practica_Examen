using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica.Examen.CalculadoraServicio.Logica.Validacion
{
    public class Peri_Romboide
    {
        public bool LosOperadoresSonCorrectos(double largo, double ancho)
        {
            bool elResultado = true;
            //valido que el lado sean positivos y que el ancho no sea mayor al largo

            elResultado = !((largo <= 0 || ancho <= 0) || (largo <= ancho));
            
            return elResultado;
        }
    }
}