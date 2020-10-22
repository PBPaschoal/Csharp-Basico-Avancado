/* Rio de Janeiro, dia 20 e 21 de outubro de 2020.
 * Aula 42 curso Udemy C# Avançado
 * Problema:
 * Fazer um programa para ler os dados de um produto em estoque (nome, preço e quantidade no estoque). 
 * Em seguida:
 * - Mostrar os dados do produto (nome, preço, quantidade no estoque, valor total no estoque).
 * - Realizar uma entrada no estoque e mostrar novamente os dados do produto.
 * - Realizar uma saída no estoque e mostrar novamente os dados do produto.
 * Para resolver este problema, deve criar uma CLASSE conforme baixo:
 * Produto   (classe chamada "produto")
 * - Nome : String   (atributo)
 * - Preco : double   (atributo)
 * - Quantidade : int   (atributo)
 * 
 * + ValorTotalEmEstoque() : double   (método)
 * + AdicionarProdutos(quantity : int) : void   (método)
 * + RemoverProdutos(quantity : int) : void    (método)
 * Exemplo:
 * Entre os dados do produto:
 * Nome: TV
 * Preço: 900.00
 * Quantidade no estoque: 10
 * Dados do produto: TV, $ 900.00, 10 unidades, Total: 9000.00
 * Digite o número de produtos a ser adicionado ao estoque: 5
 * Dados atualizados: TV, $ 900.00, 15 unidades, Total: $ 13500.00
 * Digite o número de produtos a ser removido do estoque: 3
 * Dados atualizados: TV, $ 900.00, 12 unidades, Total: $ 10800.00
 */

using System;
using System.Globalization;

namespace Aula42Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto(); // Classe Produto criada

            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine()); //Quantidade desejada pelo usuário para adicionar
            p.AdicionarProdutos(qte); //Adicionar quantos produtos? A quantidade que o usuário digitou anteriormente: qte 

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine()); //Quantidade desejada pelo usuário para adicionar
            p.RemoverProdutos(qte); 

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}
