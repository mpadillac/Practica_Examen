using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica.Examen.CalculadoraServicio.Logica.Especificacion
{
    public class Peri_PoligRegular
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="lado">valor del lado del polígono</param>
        /// <param name="cant_lados">número delados del polígono</param>
        /// <returns>el valor del perímetro del polígono</returns>
        public double Peri_PolRegular(double lado, int cant_lados)
        {
            var laAccion = new Practica.Examen.CalculadoraServicio.Logica.Accion.Peri_PoligRegular();
            double elResultado = laAccion.Perim_PolRegular(lado, cant_lados);
            return elResultado;
        }
    }
}