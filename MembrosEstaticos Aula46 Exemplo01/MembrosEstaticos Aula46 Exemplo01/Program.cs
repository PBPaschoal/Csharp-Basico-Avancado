/* Rio de Janeiro, dia 02-11-2020 Segunda-feira.
 * Aula 46 - Curso C# Programação Orientada a Objetos + Projetos.
 * Exercício exemplo 01:
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
 * VERSÃO 01:
 */

using System;
using System.Globalization;

namespace MembrosEstaticos_Aula46_Exemplo01
{
    class Program
    {
        static double Pi = 3.14; //Declarando PI aproximado.

        static void Main(string[] args)
        {
            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Circunferencia(raio); //Variável circ chamando a função Circunferencia.
            double volume = Volume(raio); //Variável volume chamando a função Volume.

            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Pi.ToString("F2", CultureInfo.InvariantCulture));
        }

        //Criar uma função para calcular a circunferencia:
        //Obs: Não precisa colocar a palavra public, porque está sendo utilizado dentro da mesma classe. Mas precisa colocar static
        //Porque esta dentro de uma função Main (que é statica):
        static double Circunferencia(double r) //Esse "raio" não é o mesmo da variável acima, é apenas um parâmetro.
        {
            return 2.0 * Pi * r; //Fórmula da circunferencia.
        }

        static double Volume(double r) //Função Volume.
        {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3.0); //4/3 * Pi * raio ao cubo.
        }
    }
}
