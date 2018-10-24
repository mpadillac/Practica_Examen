using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica.Examen.CalculadoraServicio.Logica.Accion
{
    public class Area_Romboide
    {
        private IList<string> MiListaDeErrores = new List<string>(new string[] { });
        public IList<string> ListaDeErrores
        {
            get
            {
                return MiListaDeErrores;
            }
        }

        internal double Are_Romboide(double bbase, double altura)
        {
            // valide que los parámetros sean correctos

            var laValidacion = new Logica.Validacion.Area_Romboide();
            double elResultado = 0.0;
            if (laValidacion.LosOperadoresSonCorrectos(bbase, altura))
                elResultado = bbase * altura;
            else
                MiListaDeErrores.Add("el valor de la base y la altura no pueden ser 0 o menores");
            return elResultado;
        }
    }
}