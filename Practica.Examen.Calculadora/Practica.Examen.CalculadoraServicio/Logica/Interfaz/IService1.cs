﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Practica.Examen.CalculadoraServicio.Logica.Servicio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        double Peri_Cuadrado(double lado);

        [OperationContract]
        double Are_Cuadrado(double lado);

        [OperationContract]
        double Peri_Rectangulo(double ancho, double largo);

        [OperationContract]
        double Area_Rectangulo(double ancho, double largo);

        [OperationContract]
        double Peri_Rombo(double lado);

        [OperationContract]
        double Area_Rombo(double Diag_mayor, double Diag_menor);

        [OperationContract]
        double Peri_PoligRegular(double lado, int cant_lados);

        [OperationContract]
        double Area_PoligRegular(double lado, double apotema, int cant_lados);

        [OperationContract]
        double Peri_Trapecio(double ladoa, double ladob, double ladoc, double ladod);

        [OperationContract]
        double Area_Trapecio(double base_mayor, double base_menor, double altura);

        [OperationContract]
        double Peri_Triangulo(double ladoa, double ladob, double ladoc);

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);
    }

    [DataContract]

    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
