using System;
using System.Globalization;
using Sec6;
namespace Course
  
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a quantidade de Produtos: ");
            int n = int.Parse(Console.ReadLine()!);

            Product[] products = new Product[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Produto #{i+1} ");
                Console.Write("Nome: ");
                string name = Console.ReadLine()!;
                Console.Write("Preço: ");
                double price = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
                products[i] = new Product(name, price);
                Console.WriteLine();
            }

            double sum = 0.0;
            for(int i = 0; i < n; i++)
            {
                sum += products[i].Price;
            }

            double avg = sum / n;
            Console.WriteLine($"Preço Médio: {avg.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}


