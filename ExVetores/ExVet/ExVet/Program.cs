using System;
using System.Globalization;

namespace ExVet
{
    class Program
    {
        static void Main(string[] args)
        {

            Rent[] vect = new Rent[10];
            Console.Write("Quantos quartos serão reservados? ");
            int n = int.Parse(Console.ReadLine()!);

            
            for(int i = 0; i <n; i++)
            {
                Console.WriteLine($"Dados do #{i+1}:");
                Console.Write("Nome: ");
                string name = Console.ReadLine()!;
                Console.Write("Email: ");
                string email = Console.ReadLine()!;
                Console.Write("Quarto: ");
                int room = int.Parse(Console.ReadLine()!);
                vect[room] = new Rent(name, email);
                Console.WriteLine();
            }

            Console.WriteLine("Quartos ocupados: ");

            for(int i = 0; i < 10; i++) 
            {
                if (vect[i] != null) 
                {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }
            Console.ReadLine();
            
        }
    }
}