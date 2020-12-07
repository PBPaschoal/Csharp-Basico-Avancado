/* Rio de Janeiro, dia 07-12-2020: Segunda-feira.
 * Aula 52, Sobrecarga.
 * 
 * Sobrecarga:
 * É um recurso que uma classe possui de oferecer mais de uma operação com o mesmo nome, porém com diferentes listas de 
 * parâmetros.
 * 
 * Proposta de melhoria:
 * Vamos criar um construtor opcional, o qual recebe apenas nome e preço do produto. A quantidade em estoque deste novo 
 * produto, por padrão, deverá então ser iniciada com o valor zero.
 * 
 * Nota: é possível também incluir um construtor padrão (sem parâmetros). */

using System;
using System.Globalization;

namespace Aula_52_Sobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Produto p = new Produto(nome, preco);

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}