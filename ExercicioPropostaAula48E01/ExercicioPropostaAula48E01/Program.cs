/* Rio de Janeiro, dia 06-12-2020: Domingo.
 * Aula 48
 * Exercício de fixação 01:
 * Faça um programa para ler a cotação do dólar, e depois um valor em dólares a ser comprado por uma pessoa em reais.
 * Informar quantos reais a pessoa vai pagar pelos dólares, considerando ainda que a pessoa terá que pagar 6% de IOF sobre
 * o valor em dólar. Criar uma classe ConversorDeMoeda para ser responsável pelos cálculos.
 * Exemplo:
 * Qual é a cotação do dólar? 3.10
 * Quantos dólares você vai comprar? 200.00
 * Valor a ser pago em reais = 657.20 */

using System;
using System.Globalization;

namespace ExercicioPropostaAula48E01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double result = ConversorDeMoeda.DolarParaReal(quantia, cotacao);

            Console.WriteLine("O valor a ser pago em reais = " + result.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}