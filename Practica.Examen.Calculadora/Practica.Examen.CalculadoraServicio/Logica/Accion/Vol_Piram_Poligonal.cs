using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica.Examen.CalculadoraServicio.Logica.Accion
{
    public class Vol_Piram_Poligonal
    {
        private IList<string> MiListaDeErrores = new List<string>(new string[] { });
        public IList<string> ListaDeErrores
        {
            get
            {
                return MiListaDeErrores;
            }
        }

        internal double Volu_Piram_Poligonal(double apotema, double cant_lados, double altura, double long_lado)
        {
            // valide que los parámetros sean correctos

            var laValidacion = new Logica.Validacion.Vol_Piram_Poligonal();
            double elResultado = 0.0;
            if (laValidacion.LosOperadoresSonCorrectos(apotema, cant_lados, altura, long_lado))
                elResultado = (apotema * cant_lados * long_lado * altura) / 6;
            else
                MiListaDeErrores.Add("el valor de la apotema, cantidad de lados, altura y longitud del lado no pueden ser 0 o menor");
            return elResultado;
        }
    }
}