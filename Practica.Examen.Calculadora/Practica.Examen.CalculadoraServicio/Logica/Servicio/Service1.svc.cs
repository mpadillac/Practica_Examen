using System;
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

        public double Peri_Cuadrado(double lado)
        {
            Logica.Especificacion.Perime_Cuadrado laEspecificacion;
            laEspecificacion = new Logica.Especificacion.Perime_Cuadrado();
            var elResultado = laEspecificacion.Peri_Cuadrado(lado);
            return elResultado;
        }
    }
}
