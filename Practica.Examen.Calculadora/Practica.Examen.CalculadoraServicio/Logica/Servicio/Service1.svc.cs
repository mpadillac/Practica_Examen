﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Practica.Examen.CalculadoraServicio.Logica.Servicio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        
        public string GetData(int value)
        {
            throw new NotImplementedException();
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lado">valor del lado del cuadrado</param>
        /// <returns>el valor del perímetro delcuadrado</returns>
        public double Peri_Cuadrado(double lado)
        {
            Logica.Especificacion.Perime_Cuadrado laEspecificacion;
            laEspecificacion = new Logica.Especificacion.Perime_Cuadrado();
            var elResultado = laEspecificacion.Peri_Cuadrado(lado);
            return elResultado;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lado">valor del lado del cuadrado</param>
        /// <returns>el valor del Área del cuadrado</returns>
        public double Are_Cuadrado(double lado)
        {
            Logica.Especificacion.Area_Cuadrado laEspecificacion;
            laEspecificacion = new Logica.Especificacion.Area_Cuadrado();
            var elResultado = laEspecificacion.Are_Cuadrado(lado);
            return elResultado;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ancho">valor del ancho del rectángulo</param>
        /// <param name="largo">varlo del largo del rectángulo</param>
        /// <returns>el valor del perímetro del rectángulo</returns>
        public double Peri_Rectangulo(double ancho, double largo)
        {
            Logica.Especificacion.Peri_Rectangulo laEspecificacion;
            laEspecificacion = new Logica.Especificacion.Peri_Rectangulo();
            var elResultado = laEspecificacion.Peri_Rectangu(ancho,largo);
            return elResultado;
        }

        public double Area_Rectangulo(double ancho, double largo)
        {
            Logica.Especificacion.Area_Rectangulo laEspecificacion;
            laEspecificacion = new Logica.Especificacion.Area_Rectangulo();
            var elResultado = laEspecificacion.Area_Rectangu(ancho, largo);
            return elResultado;
        }
    }
}
