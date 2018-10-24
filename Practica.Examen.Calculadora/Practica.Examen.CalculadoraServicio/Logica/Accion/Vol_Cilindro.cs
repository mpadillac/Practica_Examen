using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica.Examen.CalculadoraServicio.Logica.Accion
{
    public class Vol_Cilindro
    {
        private IList<string> MiListaDeErrores = new List<string>(new string[] { });
        public IList<string> ListaDeErrores
        {
            get
            {
                return MiListaDeErrores;
            }
        }

        internal double Volumen_Cilindro(double radio, double altura)
        {
            // valide que los parámetros sean correctos

            var laValidacion = new Logica.Validacion.Vol_Cilindro();
            double elResultado = 0.0;
            if (laValidacion.LosOperadoresSonCorrectos(radio, altura))
                elResultado = Math.Truncate(Math.PI * Math.Pow (radio,2) * altura);
            else
                MiListaDeErrores.Add("el valor del radio y la altura no pueden ser 0 o menores");
            return elResultado;
        }
    }
}