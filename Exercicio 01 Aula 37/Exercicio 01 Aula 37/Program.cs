/* Rio de Janeiro, Brasil.
 * Domingo: Dia 04 de outubro de 2020.
 * Aula 37 Exercício 01:
 * Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais velha.
 * Exemplo:
 * Dados da primeira pessoa:
 * Nome: Maria
 * Idade: 17
 * Dados da segunda pessoa:
 * Nome: Joao
 * Idade: 16
 * Pessoa mais velha: Maria */

using System;

namespace Exercicio_01_Aula_37
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            string primeira_nome = Console.ReadLine();
            Console.Write("Idade: ");
            int primeira_idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome: ");
            string segunda_nome = Console.ReadLine();
            Console.Write("Idade: ");
            int segunda_idade = int.Parse(Console.ReadLine());

            if (primeira_idade > segunda_idade)
            {
                Console.Write("Pessoa mais velha: " + primeira_nome + "\n\n");
            } else if (primeira_idade == segunda_idade) {
                Console.Write("Idades iguais.\n\n"); //No exercicio não pedi essa opção mas coloquei para não ter erro.
            } else
            {
                Console.Write("Pessoa mais velha: " + segunda_nome + "\n\n");
            }
        }
    }
}
