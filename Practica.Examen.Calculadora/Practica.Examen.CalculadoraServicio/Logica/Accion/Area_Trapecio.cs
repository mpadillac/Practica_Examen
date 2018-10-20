using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica.Examen.CalculadoraServicio.Logica.Accion
{
    public class Area_Trapecio
    {
        private IList<string> MiListaDeErrores = new List<string>(new string[] { });
        public IList<string> ListaDeErrores
        {
            get
            {
                return MiListaDeErrores;
            }
        }

        internal double Are_Trapecio(double base_mayor, double base_menor, double altura)
        {
            // valide que los parámetros sean correctos

            var laValidacion = new Logica.Validacion.Area_Trapecio();
            double elResultado = 0.0;
            if (laValidacion.LosOperadoresSonCorrectos(base_mayor, base_menor, altura))
                elResultado = ((base_mayor + base_menor) / 2) * altura;
            else
                MiListaDeErrores.Add("los valores de las bases y la altura no pueden ser 0 o menor");
            return elResultado;
        }
    }
}