/* Rio de Janeiro
 * Quarta-feira dia 07-10-2020
 * Aula 40 - Primeiros exercícios (classes, objetos e atributos).
 * Exercício 02
 * Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário médio dos funcionários.
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

namespace PEClassesObjAtri02
{
    class Program
    {
        static void Main(string[] args)
        {
            Dados f1 = new Dados();
            Dados f2 = new Dados();

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            f2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double Resultado = (f1.Salario + f2.Salario) / 2.0;
            Console.WriteLine("Salário médio = " + Resultado.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
