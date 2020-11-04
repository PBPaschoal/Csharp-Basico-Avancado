/* Rio de Janeiro, dia 03-11-2020 Terça-feira.
 * Aula 47 - Curso C# Programação Orientada a Objetos + Projetos.
 * Exercício exemplo 02:
 * Fazer um programa para ler um valor numérico qualquer, e daí mostrar quanto seria o valor
 * de uma circunferência e do volume de uma esfera para um raio daquele valor. Informar também
 * o valor de PI com duas casas decimais. 
 * Exemplo:
 * Entre o valor do raio: 3.0
 * Circunferência: 18.84
 * Volume: 113.04
 * Valor de PI: 3.14 
 * Checklist
 * Versão 1: métodos na própria classe do programa
 * - Nota: dentro de um método estático você não pode chamar membros de instância da mesma classe.
 * Versão 2: classe Calculadora com membros de instância
 * Versão 3: classe Calculadora com método estático 
 * VERSÃO 02:
 */

using MembrosEstaticos_Aula47_Exemplo02;
using System;
using System.Globalization;

namespace MembrosEstaticos_Aula46_Exemplo01
{
    class Program
    {

        static void Main(string[] args)
        {

            Calculadora calc = new Calculadora();

            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = calc.Circunferencia(raio); 
            double volume = calc.Volume(raio); 

            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + calc.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

