using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica.Examen.CalculadoraServicio.Logica.Accion
{
    public class Area_Rombo
    {
        private IList<string> MiListaDeErrores = new List<string>(new string[] { });
        public IList<string> ListaDeErrores
        {
            get
            {
                return MiListaDeErrores;
            }
        }

        internal double Are_Rombo(double Diag_mayor, double Diag_menor)
        {
            // valide que los parámetros sean correctos

            var laValidacion = new Logica.Validacion.Area_Rombo();
            double elResultado = 0.0;
            if (laValidacion.LosOperadoresSonCorrectos(Diag_mayor, Diag_menor))
                elResultado = (Diag_mayor * Diag_menor) / 2;
            else
                MiListaDeErrores.Add("los valores de la diagonal mayor y diagonal menor no pueden ser 0 o menor");
            return elResultado;
        }
    }
}