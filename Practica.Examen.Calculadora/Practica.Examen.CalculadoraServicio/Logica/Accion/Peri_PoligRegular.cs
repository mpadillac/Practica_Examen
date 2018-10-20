using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica.Examen.CalculadoraServicio.Logica.Accion
{
    public class Peri_PoligRegular
    {
        private IList<string> MiListaDeErrores = new List<string>(new string[] { });
        public IList<string> ListaDeErrores
        {
            get
            {
                return MiListaDeErrores;
            }
        }

        internal double Perim_PolRegular(double lado, int cant_lados)
        {
            // valide que los parámetros sean correctos

            var laValidacion = new Logica.Validacion.Peri_PoligRegular();
            double elResultado = 0.0;
            if (laValidacion.LosOperadoresSonCorrectos(lado, cant_lados))
                elResultado = lado * cant_lados;
            else
                MiListaDeErrores.Add("el valor del lado no puede ser 0 o menor y la cantidad de lados no puede ser menor a 5");
            return elResultado;
        }
    }
}