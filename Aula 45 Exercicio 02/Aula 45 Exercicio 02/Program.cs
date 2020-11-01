/* Rio de Janeiro, dia 01-11-2020, domingo.
 * Aula 45 Curso C# Completo 2020 Programação Orientada a Objetos + Projetos.
 * Exercício 02
 * Fazer um programa para ler os dados de um funcionário (nome, salário bruto e imposto).
 * Em seguida, mostrar os dados do funcionário (nome e salário líquido). Em seguida, aumentar o
 * salário do funcionário com base em um porcentagem dada (somente o salário bruto é afetado pela porcentagem)
 * e mostrar novamente os dados do funcionário. Use a classe projetada abaixo.
 * Exemplo:
 * Nome: Joao Silva
 * Salário bruto: 6000.00
 * Imposto: 1000.00
 * 
 * Funcionário: Joao Silva, $ 5000.00
 * 
 * Digite a porcentagem para aumentar o salário: 10.0
 * 
 * Dados atualizados: Joao Silva, $ 5600.00 */

using System;
using System.Globalization;

namespace Aula_45_Exercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario func = new Funcionario();

            Console.Write("Nome: ");
            func.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Funcionario: " + func);

            Console.WriteLine();
            Console.Write("Deseja aumentar o salário em qual porcentagem? ");
            double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            func.AumentarSalario(porcent);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + func);
        }
    }
}
