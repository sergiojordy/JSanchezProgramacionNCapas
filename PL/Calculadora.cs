using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Calculadora
    {

        public static void Suma()
        {
            Console.WriteLine("SUMA\n");

            Console.WriteLine("Ingresa un numero:");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa otro numero:");
            int numero2 = int.Parse(Console.ReadLine());

            CalculadoraService.CalculatorSoapClient serviceCalculadora = new CalculadoraService.CalculatorSoapClient();
            var result = serviceCalculadora.Add(numero1, numero2);
            Console.WriteLine("Resultado de la SUMA: " + result.ToString());
        }

        public static void Resta()
        {
            Console.WriteLine("RESTA\n");

            Console.WriteLine("Ingresa un numero:");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa otro numero:");
            int numero2 = int.Parse(Console.ReadLine());

            CalculadoraService.CalculatorSoapClient serviceCalculadora = new CalculadoraService.CalculatorSoapClient();
            var result = serviceCalculadora.Subtract(numero1, numero2);
            Console.WriteLine("Resultado de la resta: " + result.ToString());

        }

        public static void Multiplicacion()
        {
            Console.WriteLine("MULTIPLICACION\n");

            Console.WriteLine("Ingresa un numero:");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa otro numero:");
            int numero2 = int.Parse(Console.ReadLine());

            CalculadoraService.CalculatorSoapClient serviceCalculadora = new CalculadoraService.CalculatorSoapClient();
            var result = serviceCalculadora.Multiply(numero1, numero2);
            Console.WriteLine("Resultado de la multiplicacion: " + result);
        }

        public static void Division()
        {
            Console.WriteLine("DIVISION\n");

            Console.WriteLine("Ingresa un numero:");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa otro numero:");
            int numero2 = int.Parse(Console.ReadLine());

            CalculadoraService.CalculatorSoapClient serviceCalculadora = new CalculadoraService.CalculatorSoapClient();
            var result = serviceCalculadora.Divide(numero1, numero2);
            Console.WriteLine("Resultado de la division: " + result);
        }
    }
}
