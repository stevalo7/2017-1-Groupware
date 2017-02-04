using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Ulatina.Topicos.Calculadora
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class CalculadoraVector : ICalculadoraVector
    {
        public double Sumar(IEnumerable<double> laLista)
        {
            // primera forma de declarar variables
            //Dominio.Acciones.Sumar laAccion = new Dominio.Acciones.Sumar();
            // segunda forma de declarar variables
            var laAccion = new Dominio.Acciones.Sumar();
            //return laAccion.RealizarOperacion(laLista);
            double resultado = laAccion.RealizarOperacion(laLista);
            return resultado;
        }

        public double Restar(IEnumerable<double> laLista)
        {
            // primera forma de declarar variables
            //Dominio.Acciones.Sumar laAccion = new Dominio.Acciones.Sumar();
            // segunda forma de declarar variables
            var laAccion = new Dominio.Acciones.Restar();
            //return laAccion.RealizarOperacion(laLista);
            double resultado = laAccion.RealizarOperacion(laLista);
            return resultado;
        }

        public double Multiplicar(IEnumerable<double> laLista)
        {
            // primera forma de declarar variables
            //Dominio.Acciones.Sumar laAccion = new Dominio.Acciones.Sumar();
            // segunda forma de declarar variables
            var laAccion = new Dominio.Acciones.Multiplicar();
            //return laAccion.RealizarOperacion(laLista);
            double resultado = laAccion.RealizarOperacion(laLista);
            return resultado;
        }

        public double Dividir(IEnumerable<double> laLista)
        {
            // primera forma de declarar variables
            //Dominio.Acciones.Sumar laAccion = new Dominio.Acciones.Sumar();
            // segunda forma de declarar variables
            var laAccion = new Dominio.Acciones.Dividir();
            //return laAccion.RealizarOperacion(laLista);
            double resultado = laAccion.RealizarOperacion(laLista);
            return resultado;
        }


        public string GetMyData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
