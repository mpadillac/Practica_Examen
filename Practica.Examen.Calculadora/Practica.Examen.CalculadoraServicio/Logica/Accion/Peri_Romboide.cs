using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica.Examen.CalculadoraServicio.Logica.Accion
{
    public class Peri_Romboide
    {
        private IList<string> MiListaDeErrores = new List<string>(new string[] { });
        public IList<string> ListaDeErrores
        {
            get
            {
                return MiListaDeErrores;
            }
        }

        internal double Perim_Romboide(double largo, double ancho)
        {
            // valide que los parámetros sean correctos

            var laValidacion = new Logica.Validacion.Peri_Romboide();
            double elResultado = 0.0;
            if (laValidacion.LosOperadoresSonCorrectos(largo,ancho))
                elResultado = 2 * (largo + ancho);
            else
                MiListaDeErrores.Add("el valor del largo y ancho no pueden ser 0 o menores");
            return elResultado;
        }
    }
}