/* Rio de Janeiro, 21-09-2020 às 22:20hrs
 * Aula 26 Curso C# Completo.
 * Operadores Lógicos.
 */

using System;

namespace OperadoresLogicosAula26
{
    class Program
    {
        static void Main(string[] args)
        {
            bool c1 = 2 > 3 || 4 != 5;

            bool c2 = !(2 > 3) && 4 != 5;

            bool c3 = 10 < 5;

            bool c4 = c1 || c2 && c3;

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine("-----------------------");
            Console.WriteLine(c3);
            Console.WriteLine(c4);
        }
    }
}
