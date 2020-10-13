using System; //Importação de dependências. A nossa classe dependeu do System

namespace Aula_38_Exemplo_Problema_01 //Namespace da classe.
{
    class Triangulo //Nome da classe.
    {
        public double A;
        public double B; //Atributos da classe.
        public double C;
        //O prefixo "public" indica que o atributo ou método pode ser usado em outros arquivos.

        public double Area() {
            //double: Tipo do dado que o método retorna (se o método não retornar nada, usa-se a palavra "void").
            //Area: Nome do método.
            /*():Lista de parâmetros do método.No caso não foi necessário nenhum parâmetro porque todos os dados necessários para
            calcular a área já pertencem a classe(lados as, B e C)*/

            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));//Linha 16 e 17: Corpo do método.
        }
    }
}
