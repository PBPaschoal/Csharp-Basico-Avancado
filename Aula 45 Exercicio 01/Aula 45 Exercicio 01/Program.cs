/*Rio de Janeiro, dia 25-10-2020 Domingo.
 * Exercício 1
 * Fazer um programa para ler os valores da largura e altura de um retângulo. 
 * Em seguida, mostrar na tela o valor da sua área, perímetro e diagonal.
 * Usar uma classe como mostrado no projeto ao lado. */

using System;
using System.Globalization;

namespace Aula_45_Exercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo p = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo: ");
            p.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            p.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("AREA = " + p.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERÍMETRO = " + p.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + p.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
