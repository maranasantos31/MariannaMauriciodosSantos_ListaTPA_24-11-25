using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantas letras terá sua palavra?: ");
            int num = int.Parse(Console.ReadLine());

            char[] palavra = new char[num];

            for (int i = 0; i < num; i++)
            {
                Console.Write("Digite uma letra: ");
                palavra[i] = char.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nVocê tem 3 tentativas para descobrir uma letra da palavra!");

            for (int tent = 1; tent <= 3; tent++)
            {
                Console.Write($"\nTentativa {tent}: Informe uma letra: ");
                char chute = char.Parse(Console.ReadLine());

                bool existe = false;

                for (int i = 0; i < num; i++)
                {
                    if (palavra[i] == chute)
                    {
                        existe = true;
                        break;
                    }
                }

                if (existe)
                {
                    Console.WriteLine("A letra existe na palavra!");
                }
                else
                {
                    Console.WriteLine("A letra NÃO existe na palavra.");
                }
            }

            Console.WriteLine("\nPalavra completa:");
            for (int i = 0; i < num; i++)
                Console.Write(palavra[i]);

            Console.WriteLine("\n\nPalavra em várias linhas:");
            for (int i = 0; i < num; i++)
                Console.WriteLine(palavra[i]);
        }
    }
}   
