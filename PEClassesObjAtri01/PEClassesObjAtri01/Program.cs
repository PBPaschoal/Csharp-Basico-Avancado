/* Rio de Janeiro
 * Quarta-feira dia 07-10-2020
 * Aula 40 - Primeiros exercícios (classes, objetos e atributos).
 * Exercício 01:
 * Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais velha.
 * Exemplo:
 * Dados da primeira pessoa:
 * Nome: Maria
 * Idade: 17
 * Dados da segunda pessoa:
 * Nome: João
 * Idade: 16
 * Pessoa mais velha: Maria */

using System;

namespace PEClassesObjAtri01
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 N, I;

            N = new Class1();
            I = new Class1();

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            String NomeP01 = Console.ReadLine();
            Console.Write("Idade: ");
            int IdadeP01 = int.Parse(Console.ReadLine());
            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome: ");
            String NomeP02 = Console.ReadLine();
            Console.Write("Idade: ");
            int IdadeP02 = int.Parse(Console.ReadLine());

            if (IdadeP01 > IdadeP02)
            {
                Console.WriteLine("Pessoa mais velha: " + NomeP01);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + NomeP02);
            }
        }
    }
}
