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
    internal static class Aritmetica
    {
      
        /// <summary>
        /// Operação de soma entre dois números inteiros.
        /// </summary>
        /// <returns>Retorna a soma dos dois números.</returns>
        public static int Somar(int a, int b)
        {
            return a + b;
        }
        /// <summary>
        /// Operação de subtração entre dois números inteiros.
        /// </summary>
        /// <returns>Retorna a subtração dos dois números.</returns>
        public static int Subtrair(int a, int b)
        {
            return a - b;
        }
    }
}
