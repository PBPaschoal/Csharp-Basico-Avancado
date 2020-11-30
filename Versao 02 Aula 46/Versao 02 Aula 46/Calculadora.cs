namespace Versao_02_Aula_46
{
    class Calculadora
    {
        public double Pi = 3.14;

        public double Circunferencia(double r)
        {
            return 2.0 * Pi * r;
        }

        public double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * r * r * r;
        }
    }
}