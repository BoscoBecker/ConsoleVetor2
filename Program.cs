using ConsoleVetor2.Entidade;
using System;
using System.Numerics;

namespace ConsoleVetor2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a quantidade de produtos:");
            Vetor Vect = new Vetor();
            int quantidade  = int.Parse( Console.ReadLine());
            Vect.AdicionaVetor(quantidade);
            Console.WriteLine(Vect);
        }
    }
}
