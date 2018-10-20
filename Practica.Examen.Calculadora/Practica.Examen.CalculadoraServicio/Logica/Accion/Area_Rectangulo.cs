using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica.Examen.CalculadoraServicio.Logica.Accion
{
    public class Area_Rectangulo
    {
        private IList<string> MiListaDeErrores = new List<string>(new string[] { });
        public IList<string> ListaDeErrores
        {
            get
            {
                return MiListaDeErrores;
            }
        }

        internal double Area_Rectangu(double ancho, double largo)
        {
            // valide que los parámetros sean correctos

            var laValidacion = new Logica.Validacion.Area_Rectangulo();
            double elResultado = 0.0;
            if (laValidacion.LosOperadoresSonCorrectos(ancho, largo))
                elResultado = ancho * largo;
            else
                MiListaDeErrores.Add("los valores del ancho y el largo no pueden ser 0 o menor");
            return elResultado;
        }
    }
}