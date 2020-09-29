/* Rio de Janeiro, dia 28.09.2020
 * Demo:
 * Digitar um número N e depois N valores inteiros. Mostrar a soma dos N valores digitados. 
 * Exemplo:
 * Quantos números inteiros você vai digitar? 3
 * Valor #1: 10
 * Valor #2: 7
 * Valor #3: 8
 * Soma = 25 */

using System;

namespace Aula_34_Estrutura_repetitiva_para__for_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos números inteiros você vai digitar? ");
            int N = int.Parse(Console.ReadLine());

            int soma = 0;
            for (int i = 1; i <= N; i++)
            {
                Console.Write("Valor #{0}: ", i);
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            }

            Console.WriteLine("Soma = " + soma);
            
        }
    }
}
