using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aplicação Cálculos");

            Console.WriteLine($"4 + 2 = {Aritmetica.Somar(4, 2)}");
            Console.WriteLine($"4 - 2 = {Aritmetica.Subtrair(4, 2)}");
            Console.WriteLine($"Celsius para Fahrenheit: 36°C = {Conversoes.ConverterTemperatura(36, Conversoes.ConversaoTemperatura.CelsiusParaFahrenheit)}°F");
            Console.WriteLine($"Fahrenheit para Celsius: 100°F = {Conversoes.ConverterTemperatura(100, Conversoes.ConversaoTemperatura.FahrenheitParaCelsius)}°C");




            Console.ReadKey();
        }
    }
}
