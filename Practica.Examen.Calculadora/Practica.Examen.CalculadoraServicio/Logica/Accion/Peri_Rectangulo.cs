using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica.Examen.CalculadoraServicio.Logica.Accion
{
    public class Peri_Rectangulo
    {
        private IList<string> MiListaDeErrores = new List<string>(new string[] { });
        public IList<string> ListaDeErrores
        {
            get
            {
                return MiListaDeErrores;
            }
        }

        internal double Perim_Rectangulo(double ancho, double largo)
        {
            // valide que los parámetros sean correctos

            var laValidacion = new Logica.Validacion.Peri_Rectangulo();
            double elResultado = 0.0;
            if (laValidacion.LosOperadoresSonCorrectos(ancho,largo))
                elResultado = 2 * (ancho + largo);
            else
                MiListaDeErrores.Add("los valores del ancho y el largo no pueden ser 0 o menor");
            return elResultado;
        }
    }
}