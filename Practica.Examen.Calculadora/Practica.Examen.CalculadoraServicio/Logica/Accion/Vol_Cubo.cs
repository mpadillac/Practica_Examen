using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica.Examen.CalculadoraServicio.Logica.Accion
{
    public class Vol_Cubo
    {
        private IList<string> MiListaDeErrores = new List<string>(new string[] { });
        public IList<string> ListaDeErrores
        {
            get
            {
                return MiListaDeErrores;
            }
        }

        internal double Volumen_Cubo(double arista)
        {
            // valide que los parámetros sean correctos

            var laValidacion = new Logica.Validacion.Vol_Cubo();
            double elResultado = 0.0;
            if (laValidacion.LosOperadoresSonCorrectos(arista))
                elResultado = Math.Pow(arista, 3);
            else
                MiListaDeErrores.Add("el valor de la arista no puede ser 0 o menor");
            return elResultado;
        }
    }
}