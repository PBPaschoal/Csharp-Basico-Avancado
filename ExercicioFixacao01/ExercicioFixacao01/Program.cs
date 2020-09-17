/* Inicializando o curso de C# Completo, do básico ao avançado.
 * Aula 20.
 * Exercício de Fixação:
 * Em um novo programa, inicie as seguintes variáveis:
 * string produto1 = "Computador";
 * string produto2 = "mesa de escritório";
 * 
 * byte idade = 30;
 * int codigo = 5290;
 * char genero = 'M';
 * 
 * double preco1 = 2100.0;
 * double preco2 = 650.50;
 * double medida = 53.234567;
 * 
 * Em seguida, usando os valores das variáveis, produza a seguinte saída na tela do console:
 * Produtos:
 * Computador, cujo preço é $ 2100,00
 * Mesa de escritório, cujo preço é $ 650,50
 * 
 * Registro: 30 anos de idade, código 5290 e gênero: M
 * 
 * Medida com oito casas decimais: 53,23456700
 * Arredondado (três casas decimais): 53,235
 * Separador decimal invariant cultur: 53.235
 */

using System;
using System.Globalization;

namespace Exercicio_de_Fixacao_Aula_20_Curso_csharp_completo
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine(produto1 + ", cujo preço é $ {0:F2} ", preco1);
            Console.WriteLine(produto2 + ", cujo preço é $ {0:F2} ", preco2);

            Console.WriteLine("\nRegistro: " + idade + " anos de idade, código " + codigo + " e gênero: " + genero);

            Console.WriteLine("\nMedida com oito casas decimais: {0:F8}", medida);
            Console.WriteLine("Arredondado (três casas decimais): {0:F3}", medida);
            Console.WriteLine("Separador decimal invariant Culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}