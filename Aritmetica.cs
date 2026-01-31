using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    /// <summary>
    /// Implementa operações aritméticas básicas.
    /// </summary>
    internal class Aritmetica
    {
        /// <summary>
        /// Tipo de conversão de temperatura a executar.
        /// </summary>
        public enum ConversaoTemperatura
        {
            Nulo = 0,
            CelsiusParaFahrenheit,
            FahrenheitParaCelsius
        }
        /// <summary>
        /// Operação de soma entre dois números inteiros.
        /// </summary>
        /// <returns>Retorna a soma dos dois números.</returns>
        public int Somar(int a, int b)
        {
            return a + b;
        }
        /// <summary>
        /// Operação de subtração entre dois números inteiros.
        /// </summary>
        /// <returns>Retorna a subtração dos dois números.</returns>
        public int Subtrair(int a, int b)
        {
            return a - b;
        }
        public double ConverterTemperatura(double valor, ConversaoTemperatura tipoConversao)
        {
            switch (tipoConversao)
            {
                case ConversaoTemperatura.CelsiusParaFahrenheit:
                    return (valor * 9 / 5) + 32;
                case ConversaoTemperatura.FahrenheitParaCelsius:
                    return (valor - 32) * 5 / 9;
                default:
                    throw new ArgumentException("Tipo de conversão inválido.");
            }
        }
    }
}
