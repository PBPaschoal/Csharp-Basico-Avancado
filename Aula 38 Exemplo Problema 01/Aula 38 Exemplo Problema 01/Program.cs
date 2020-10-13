/* Rio de Janeiro, Brasil.
 * Segunda: Dia 12 de outubro de 2020.
 * Mesmo programa anterior, mas adicionando novos métodos.
 * Problema Exemplo:
 * Fazer um programa para ler as medidas dos lados de dois triângulos X e Y (suponha medidas válidas).
 * Em seguida, mostrar o valor das áreas dos dois triângulos e dizer qual dos dois triângulos possui a maior área.
 * A fórmula para calcular a área de um triângulo a partir das medidas de seus lados a, b e c é a seguinte (fórmula de Heron):
 * área = raiz quadrada de p(p-a)(p-b)(p-c) onde p = a+b+c sobre 2
 * Obs: Sem utilizar a POO.
 * Exemplo:
 * Entre com as medidas do triângulo X:
 * 3.00
 * 4.00
 * 5.00
 * Entre com as medidas do triângulo Y:
 * 7.50
 * 4.50
 * 4.02
 * Área de X = 6.000
 * Área de Y = 7.5638
 * Maior área: Y
 * Aula 41 Revisando*/

using System;
using System.Globalization;

namespace Aula_38_Exemplo_Problema_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo X:");
             x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com as medidas do triângulo Y:");
             y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.Area();

            double areaY = y.Area();
            //Eliminamos o código repetido (cálculo das áreas dos triângulos x e y) no programa principal.
            /*Quem deve ser responsável por saber como calcular a área de um triângulo é o próprio triângulo.
            A lógica do cálcuo da área não deve estar em outro lugar. */

            Console.WriteLine("Área de x = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }
        }
    }
}
