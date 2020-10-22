/* Rio de Janeiro
 * Quarta-feira dia 07-10-2020.
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

            Class1 p1 = new Class1();
            Class1 p2 = new Class1();

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p1.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome: ");
            p2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p2.Idade = int.Parse(Console.ReadLine());

            if (p1.Idade > p2.Idade)
            {
                Console.WriteLine("Pessoa mais velha: " + p1.Nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + p2.Nome);
            }
        }
    }
}
