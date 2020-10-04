/*Rio de Janeiro, Brasil.
 * Domingo: Dia 04 de outubro de 2020.
 * Aula 37 Exercício 02: 
 * Fazer um programa para ler o nome e salário de dois funcionários.
 * Depois, mostrar o salário médio dos funcionários.
 * Exemplo:
 * Dados do primeiro funcionário:
 * Nome: Carlos Silva
 * Salário: 6300.00
 * Dados do segundo funcionário:
 * Nome: Ana Marques
 * Salário: 6700.00
 * Salário médio = 6500.00 */

using System;
using System.Globalization;

namespace Exercicio_02_Aula_37
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            string nome_primeirofuncio = Console.ReadLine();
            Console.Write("Salário: ");
            double salario01 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            string nome_segundofuncio = Console.ReadLine();
            Console.Write("Salário: ");
            double salario02 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double Resultado = (salario01 + salario02) / 2.0;

            Console.Write("Salário médio = " + Resultado.ToString("F2", CultureInfo.InvariantCulture) + "\n\n");

        }
    }
}
