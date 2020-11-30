/* Rio de Janeiro, dia 28-11-2020
 * Aula 46 Membros estáticos
 * Problema exemplo:
 * Fazer um programa para ler um valor numérico qualquer, e daí mostrar quanto seria o valor de uma circunferência
 * e do volume de uma esfera para um raio daquele valor. Informar também o valor de PI com duas casas decimais.
 * Exemplo:
 * Entre o valor do raio: 3.0
 * Circunferência: 18.84
 * Volume: 113.04
 * Valor de PI: 3.14
 * -----
 * Vamos solucionar de 3 metodos diferentes:
 * Checklist
 * Versão 1: Métodos na própria classe do programa - Nota: dentro de um método estático você não pode chamar membros
 * de instância da mesma classe.
 * Versão 2: Classe Calculadora com membros de instância.
 * Versão 3: Classe Calculadora com método estático. */

//Versão 01:

using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static double Pi = 3.14;

        static void Main(string[] args)
        {
            Console.WriteLine("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Circunferencia(raio);
            double volume = Volume(raio);

            Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Pi.ToString("F2", CultureInfo.InvariantCulture));
        }

        static double Circunferencia(double r)
        {
            return 2.0 * Pi * r;
        }

        static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3.0); // r * r * r
        }
    }
}
