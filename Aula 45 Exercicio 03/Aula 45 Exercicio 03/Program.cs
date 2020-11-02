/* Rio de Janeiro, dia 01-11-2020, domingo.
 * Aula 45 Curso C# Completo 2020 Programação Orientada a Objetos + Projetos.
 * EXERCÍCIO 03:
 * Fazer um programa para ler o nome de um aluno e as três notas que ele obteve nos três trimestres do ano
 * (primeiro trimestre vale 30 e o segundo e terceiro valem 35 cada). Ao final, mostrar qual a nota final do aluno no
 * ano. Dizer também se o aluno está APROVADO ou REPROVADO e, em caso negativo, quantos pontos faltam
 * para o aluno obter o mínimo para ser aprovado (que é 60 pontos). Você deve criar uma classe Aluno para resolver
 * este problema.
 * Exemplos:
 * Nome do aluno: Alex Green
 * Digite as três notas do aluno:
 * 27.00
 * 31.00
 * 32.00
 * NOTA FINAL = 90.00
 * APROVADO
 * 
 * Nome do aluno: Alex Green
 * Digite as três notas do aluno:
 * 17.00
 * 20.00
 * 15.00
 * NOTA FINAL = 52.00
 * REPROVADO
 * FALTARAM 8.00 PONTOS */

using System;
using System.Globalization;

namespace Aula_45_Exercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("NOTA FINAL = "
            + aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
            if (aluno.Aprovado())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM "
                + aluno.NotaRestante().ToString("F2", CultureInfo.InvariantCulture)
                + " PONTOS");
            }
        }
    }
}
