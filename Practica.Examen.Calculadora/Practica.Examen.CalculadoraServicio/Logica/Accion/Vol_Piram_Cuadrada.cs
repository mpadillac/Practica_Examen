using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica.Examen.CalculadoraServicio.Logica.Accion
{
    public class Vol_Piram_Cuadrada
    {
        private IList<string> MiListaDeErrores = new List<string>(new string[] { });
        public IList<string> ListaDeErrores
        {
            get
            {
                return MiListaDeErrores;
            }
        }

        internal double Volumen_Piram_Cuadrada(double lbase, double altura)
        {
            // valide que los parámetros sean correctos

            var laValidacion = new Logica.Validacion.Vol_Piram_Cuadrada();
            double elResultado = 0.0;
            if (laValidacion.LosOperadoresSonCorrectos(lbase, altura))
                elResultado = Math.Pow(lbase,2) * altura * 1/3;
            else
                MiListaDeErrores.Add("el valor del lado de la base y la altura no pueden ser 0 o menores");
            return elResultado;
        }
    }
}