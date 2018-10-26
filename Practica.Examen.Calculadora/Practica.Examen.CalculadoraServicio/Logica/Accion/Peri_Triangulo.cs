using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica.Examen.CalculadoraServicio.Logica.Accion
{
    public class Peri_Triangulo
    {
        private IList<string> MiListaDeErrores = new List<string>(new string[] { });
        public IList<string> ListaDeErrores
        {
            get
            {
                return MiListaDeErrores;
            }
        }

        internal double Perim_Triangulo(double ladoa, double ladob, double ladoc)
        {
            // valide que los parámetros sean correctos

            var laValidacion = new Logica.Validacion.Peri_Triangulo();
            double elResultado = 0.0;
            if (laValidacion.LosOperadoresSonCorrectos(ladoa, ladob, ladoc))
                elResultado = ladoa + ladob + ladoc;
            else
                MiListaDeErrores.Add("el valor de los lados no pueden ser 0 o menor y la suma de sus lados menores, debe ser mayor al valor del lado mayor");
            return elResultado;
        }

        
    }
}