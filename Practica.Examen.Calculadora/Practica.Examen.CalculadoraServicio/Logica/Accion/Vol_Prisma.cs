using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica.Examen.CalculadoraServicio.Logica.Accion
{
    public class Vol_Prisma
    {
        private IList<string> MiListaDeErrores = new List<string>(new string[] { });
        public IList<string> ListaDeErrores
        {
            get
            {
                return MiListaDeErrores;
            }
        }

        internal double Volumen_Prisma(double arebase, double altura)
        {
            // valide que los parámetros sean correctos

            var laValidacion = new Logica.Validacion.Vol_Prisma();
            double elResultado = 0.0;
            if (laValidacion.LosOperadoresSonCorrectos(arebase, altura))
                elResultado = arebase * altura;
            else
                MiListaDeErrores.Add("el valor del área de la base y la altura no pueden ser 0 o menores");
            return elResultado;
        }
    }
}