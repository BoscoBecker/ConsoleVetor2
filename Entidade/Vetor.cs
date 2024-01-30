using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;


namespace ConsoleVetor2.Entidade
{
    class Vetor
    {
        private double Sum;
        private double Resultado { get; set; }
        public void AdicionaVetor(int quantidade)
        {
            Product[] Vect = new Product[quantidade];
            for (int i = 0; i < quantidade; i++)
            {
                Console.Write("Informe o nome do produto: ");
                string name = Console.ReadLine();
                Console.Write("Informe o Preço do produto: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Vect[i] = new Product { Name = name, Price = price };
                Sum += Vect[i].Price;
            }
            Resultado = AVG(Sum, quantidade);
        }
        private double AVG(double price, int quantidade)
        {
            return (price / quantidade);
        }

        public override string ToString()
        {
            return "AVERAGE PRICE:" + Resultado.ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
