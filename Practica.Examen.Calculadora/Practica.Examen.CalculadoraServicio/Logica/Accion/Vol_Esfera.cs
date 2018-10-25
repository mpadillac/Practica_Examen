using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica.Examen.CalculadoraServicio.Logica.Accion
{
    public class Vol_Esfera
    {
        private IList<string> MiListaDeErrores = new List<string>(new string[] { });
        public IList<string> ListaDeErrores
        {
            get
            {
                return MiListaDeErrores;
            }
        }

        internal double Volumen_esfera(double radio)
        {
            // valide que los parámetros sean correctos

            var laValidacion = new Logica.Validacion.Vol_Esfera();
            double elResultado = 0.0;
            if (laValidacion.LosOperadoresSonCorrectos(radio))
                elResultado = Math.Truncate((Math.Pow(radio,3)) * 3/4 * Math.PI);
            else
                MiListaDeErrores.Add("el valor del radio no puede ser 0 o menor");
            return elResultado;
        }
    }
}