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
            Dados Nom, SaLr;

            Nom = new Dados();
            SaLr = new Dados();

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            String Nome01 = Console.ReadLine();
            Console.Write("Salário: ");
            double Salario01 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            String Nome02 = Console.ReadLine();
            Console.Write("Salário: ");
            double Salario02 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double Resultado = (Salario01 + Salario02) / 2.0;
            Console.WriteLine("Salário médio = " + Resultado.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
