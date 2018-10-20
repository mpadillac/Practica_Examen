using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica.Examen.CalculadoraServicio.Logica.Accion
{
    public class Area_PolRegular
    {
        private IList<string> MiListaDeErrores = new List<string>(new string[] { });
        public IList<string> ListaDeErrores
        {
            get
            {
                return MiListaDeErrores;
            }
        }

        internal double Area_PolRegula(double lado, double apotema, int cant_lados)
        {
            // valide que los parámetros sean correctos

            var laValidacion = new Logica.Validacion.Area_PolRegular();
            double elResultado = 0.0;
            if (laValidacion.LosOperadoresSonCorrectos(lado, apotema, cant_lados))
                elResultado = (lado * cant_lados * apotema) / 2;
            else
                MiListaDeErrores.Add("el valor del lado y la apotema no pueden ser 0 o menor y la cantidad de lados no puede ser menor a 5");
            return elResultado;
        }
    }
}