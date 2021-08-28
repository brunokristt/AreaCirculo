using System;
using System.Globalization;
 

namespace AreaCirculo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de área de circulos");
            Console.Write("Digite o raio do circulo: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double CalculaArea(double raio)
            {
                double resultado = 3.14159 * raio * raio;
                return resultado;
            }

            double area = CalculaArea(raio);

            Console.WriteLine("O valor da área do círculo é: " + area.ToString("F4"), CultureInfo.InvariantCulture);
        }
    }
}
