using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica.Examen.CalculadoraServicio.Logica.Validacion
{
    public class Peri_Triangulo
    {
        public bool LosOperadoresSonCorrectos(double ladoa, double ladob, double ladoc)
        {
            bool elResultado = true;
            // valido que los lados sean positivos y que dos de los lados pequeños no sean más grandes que el mayor
            //var A = ladoa + ladob;
            //var B = ladoa + ladoc;
            //var C = ladob + ladoc;
            double ladomayor;
            double suma;

            ladomayor = Encontrarelmayor(ladoa, ladob, ladoc);
            suma = Encontrarmenores(ladoa, ladob, ladoc);

            elResultado = !(ladoa <= 0 || ladob <= 0 || ladoc <= 0 || ladomayor > suma);
            //elResultado = !(ladoa <= C && ladob <= B && ladoc <= A);

            return elResultado;
        }

        internal double Encontrarelmayor(double ladoa, double ladob, double ladoc)
        {
            double ladomayor;

            if (ladoa > ladob & ladoa > ladoc)
            {
                ladomayor = ladoa;
            }

            if (ladob > ladoa & ladob > ladoc)
            {
                ladomayor = ladob;
            }

            else
            {
                ladomayor = ladoc;
            }

            return ladomayor;


        }

        internal double Encontrarmenores(double ladoa, double ladob, double ladoc)
        {
            double ladomayor;
            double suma;

            if (ladoa > ladob & ladoa > ladoc)
            {
                ladomayor = ladoa;
                suma = ladob + ladoc;
            }

            if (ladob > ladoa & ladob > ladoc)
            {
                ladomayor = ladob;
                suma = ladoc + ladoa;
            }

            else
            {
                ladomayor = ladoc;
                suma = ladoa + ladob;
            }

            return suma;
        }
    }
}