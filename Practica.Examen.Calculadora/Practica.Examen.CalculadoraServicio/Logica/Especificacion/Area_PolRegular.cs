using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica.Examen.CalculadoraServicio.Logica.Especificacion
{
    public class Area_PolRegular
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="lado">valor del lado del polígono regular</param>
        /// <param name="apotema">valor de la apotema</param>
        /// <param name="cant_lados">cantidad de lados del polígono regular</param>
        /// <returns>el valor del área del polígono regular</returns>
        public double Area_PolRegula(double lado, double apotema, int cant_lados)
        {
            var laAccion = new Practica.Examen.CalculadoraServicio.Logica.Accion.Area_PolRegular();
            double elResultado = laAccion.Area_PolRegula(lado, apotema, cant_lados);
            return elResultado;
        }
    }
}