/* Rio de Janeiro, dia 27-09-2020
 * Digitar um número e mostrar sua raiz quadrada com três casas decimais,
 * depois repetir o procedimento. Quando o usuário digitar um número
 * negativo (podendo inclusive ser na primeira vez), mostrar uma mensagem
 * "Número negativo" e terminar o programa. 
 * Exemplo:
 * Digite um número: 25
 * 5.000
 * Digite outro número: 10
 * 3.162
 * Digite outro número: 9
 * 3.000
 * Digite outro número: -4
 * Número negativo! */


using System;
using System.Globalization;

namespace Aula_32_Estrutura_de_repetição_while_Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            double N = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (N >= 0.0)
            {
                double raiz = Math.Sqrt(N);
                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
                Console.Write("Digite outro número: ");
                N = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Console.WriteLine("Número negativo!");
        }
    }
}