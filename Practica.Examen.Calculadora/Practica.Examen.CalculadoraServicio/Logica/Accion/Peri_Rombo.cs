using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica.Examen.CalculadoraServicio.Logica.Accion
{
    public class Peri_Rombo
    {
        private IList<string> MiListaDeErrores = new List<string>(new string[] { });
        public IList<string> ListaDeErrores
        {
            get
            {
                return MiListaDeErrores;
            }
        }

        internal double Perim_Rombo(double lado)
        {
            // valide que los parámetros sean correctos

            var laValidacion = new Logica.Validacion.Peri_Rombo();
            double elResultado = 0.0;
            if (laValidacion.LosOperadoresSonCorrectos(lado))
                elResultado = 4 * lado;
            else
                MiListaDeErrores.Add("el valor del lado no puede ser 0 o menor");
            return elResultado;
        }
    }
}