using System;

namespace senai.operadores.ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 5");

            Console.WriteLine("Informe o preço do produto");
            float p = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade atual do produto");
            float ea = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidadee minima do produto");
            float qMin = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade maxima do produto");
            float qMax = float.Parse(Console.ReadLine());

            float em = (float)((qMin+qMax)/2);

            float totp = (float)( p*em );

            float _ct = (float)( p*ea);

            Console.WriteLine("Há " + ea + " produtos no estoque."
            + "O estoque médio recomendado é de: " + em
            + ". O custo total considerando o estoque médio é de: " + totp
            + ". O custo total considerando o estoque atual é de: " + _ct);
        }
    }
}
