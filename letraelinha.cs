using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantas letras terá sua palavra?: ");
            int num = int.Parse(Console.ReadLine());

            char[] vet = new char[num];

            for (int i = 0; i < num; i++)
            {
                Console.Write("Digite uma letra: ");
                vet[i] = char.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nPalavra em uma linha: ");
            for (int i = 0; i < num; i++)
                Console.Write(vet[i]);

            Console.WriteLine("\n\nPalavra em várias linhas:");
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(vet[i]);
            }
        }
    }
}