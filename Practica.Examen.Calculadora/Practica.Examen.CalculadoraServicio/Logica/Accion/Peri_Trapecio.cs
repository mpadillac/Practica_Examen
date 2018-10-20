using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica.Examen.CalculadoraServicio.Logica.Accion
{
    public class Peri_Trapecio
    {
        private IList<string> MiListaDeErrores = new List<string>(new string[] { });
        public IList<string> ListaDeErrores
        {
            get
            {
                return MiListaDeErrores;
            }
        }

        internal double Perim_Trapecio(double ladoa, double ladob, double ladoc, double ladod)
        {
            // valide que los parámetros sean correctos

            var laValidacion = new Logica.Validacion.Peri_Trapecio();
            double elResultado = 0.0;
            if (laValidacion.LosOperadoresSonCorrectos(ladoa, ladob, ladob, ladod))
                elResultado = ladoa + ladob + ladoc + ladod;
            else
                MiListaDeErrores.Add("el valor de los lados no pueden ser 0 o menor");
            return elResultado;
        }
    }
}