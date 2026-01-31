using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    /// <summary>
    /// Implementa operações de conversão.
    /// </summary>  
    internal static class Conversoes
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
        /// Conversão de temperaturas.
        /// </summary>  
        /// <param name="conversao">A conversão a efetuar.</param>
        /// <param name="temperatura">A temperatura a converter.</param>
        /// <returns>Retorna o resultado da conversão</returns>
        
        public static double ConverterTemperatura(double valor, ConversaoTemperatura tipoConversao)
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
