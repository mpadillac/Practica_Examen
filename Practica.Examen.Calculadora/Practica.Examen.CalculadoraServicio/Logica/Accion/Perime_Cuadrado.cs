﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica.Examen.CalculadoraServicio.Logica.Accion
{
    public class Perime_Cuadrado
    {
        private IList<string> MiListaDeErrores = new List<string>(new string[] { });
        public IList<string> ListaDeErrores
        {
            get
            {
                return MiListaDeErrores;
            }
        }

        internal double Peri_Cuadrado(double lado)
        {
            // valide que los parámetros sean correctos

            var laValidacion = new Logica.Validacion.Perime_Cuadrado();
            double elResultado = 0.0;
            if (laValidacion.LosOperadoresSonCorrectos(lado))
                elResultado = lado * 4;
            else
                MiListaDeErrores.Add("El valor no puede ser 0 o menor");
            return elResultado;
        }
    }
}