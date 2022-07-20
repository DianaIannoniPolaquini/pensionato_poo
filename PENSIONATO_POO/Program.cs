using System;

namespace PENSIONATO_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudante[] vet = new Estudante[10];

            Console.Write("Quantos quartos serão alugado? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Aluguel {i+1}:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("E-mail: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vet[quarto] = new Estudante(nome, email);
                Console.WriteLine();    
            }
            Console.WriteLine();
            Console.WriteLine("Quartos ocupados: ");

            for (int i = 0;i < 10; i++)
            {
                if (vet[i] != null)
                {
                    Console.WriteLine($"Quarto {i} : {vet[i]}");
                }
            }
        }
    }
}
