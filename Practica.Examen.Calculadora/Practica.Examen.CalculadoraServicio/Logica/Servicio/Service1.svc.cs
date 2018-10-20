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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ancho">valor del ancho del rectángulo</param>
        /// <param name="largo">valor del largo del rectángulo</param>
        /// <returns>valor del área del rectángulo</returns>
        public double Area_Rectangulo(double ancho, double largo)
        {
            Logica.Especificacion.Area_Rectangulo laEspecificacion;
            laEspecificacion = new Logica.Especificacion.Area_Rectangulo();
            var elResultado = laEspecificacion.Area_Rectangu(ancho, largo);
            return elResultado;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lado">valor del lado del rombo</param>
        /// <returns>valor del perímetro del rombo</returns>
        public double Peri_Rombo(double lado)
        {
            Logica.Especificacion.Peri_Rombo laEspecificacion;
            laEspecificacion = new Logica.Especificacion.Peri_Rombo();
            var elResultado = laEspecificacion.Perim_Rombo(lado);
            return elResultado;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Diag_mayor">valor de la diagonal mayor</param>
        /// <param name="Diag_menor">valor de la diagonal menor</param>
        /// <returns>valor del área del rombo</returns>
        public double Area_Rombo(double Diag_mayor, double Diag_menor)
        {
            Logica.Especificacion.Area_Rombo laEspecificacion;
            laEspecificacion = new Logica.Especificacion.Area_Rombo();
            var elResultado = laEspecificacion.Area_Romb(Diag_mayor, Diag_menor);
            return elResultado;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="lado">valor del lado del polígono regular</param>
        /// <param name="cant_lados">valor de lacantidad de lados del polígono regular</param>
        /// <returns></returns>
        public double Peri_PoligRegular(double lado, int cant_lados)
        {
            Logica.Especificacion.Peri_PoligRegular laEspecificacion;
            laEspecificacion = new Logica.Especificacion.Peri_PoligRegular();
            var elResultado = laEspecificacion.Peri_PolRegular(lado, cant_lados);
            return elResultado;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="lado">valor del lado del polígono regular</param>
        /// <param name="apotema">valor de la apotema</param>
        /// <param name="cant_lados">cantidad de lados del polígono regular</param>
        /// <returns>el valor del área del polígono regular</returns>
        public double Area_PoligRegular(double lado, double apotema, int cant_lados)
        {
            Logica.Especificacion.Area_PolRegular laEspecificacion;
            laEspecificacion = new Logica.Especificacion.Area_PolRegular();
            var elResultado = laEspecificacion.Area_PolRegula(lado, apotema, cant_lados);
            return elResultado;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ladoa">valor del lado a</param>
        /// <param name="ladob">valor del lado b</param>
        /// <param name="ladoc">valor del lado c</param>
        /// <param name="ladod">valor del lado d</param>
        /// <returns>valor del perímetro del trapecio</returns>
        public double Peri_Trapecio(double ladoa, double ladob, double ladoc, double ladod)
        {
            Logica.Especificacion.Peri_Trapecio laEspecificacion;
            laEspecificacion = new Logica.Especificacion.Peri_Trapecio();
            var elResultado = laEspecificacion.Perim_Trapecio(ladoa, ladob, ladoc, ladod);
            return elResultado;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="base_mayor">valor de la base mayor</param>
        /// <param name="base_menor">valor de la base menor</param>
        /// <param name="altura">valor de la altura</param>
        /// <returns>valor del área del trapecio</returns>
        public double Area_Trapecio(double base_mayor, double base_menor, double altura)
        {
            Logica.Especificacion.Area_Trapecio laEspecificacion;
            laEspecificacion = new Logica.Especificacion.Area_Trapecio();
            var elResultado = laEspecificacion.Are_Trapecio(base_mayor, base_menor, altura);
            return elResultado;
        }
    }
}
