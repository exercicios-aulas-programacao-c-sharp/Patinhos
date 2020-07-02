using System;

namespace Patinhos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Contagem regressiva
            //N patinhos, até que não hajam patinhos
            int totalNumeroPatinhos;
            int numeroPatinhosAtual;

            bool numeroPatinhosEhValido;

            ConsoleColor corPadrao = Console.ForegroundColor;

            Console.Write("Quantos patinhos? ");
            numeroPatinhosEhValido = 
                Int32.TryParse(Console.ReadLine(), out totalNumeroPatinhos);

            if (!numeroPatinhosEhValido || totalNumeroPatinhos < 2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Número de patinhos inválido.\n Programa finalizado.");
                Console.ForegroundColor = corPadrao;
                Environment.Exit(-1);
            }    

            Console.ForegroundColor = ConsoleColor.DarkBlue;

            for (numeroPatinhosAtual = totalNumeroPatinhos; 
                 numeroPatinhosAtual > 0; 
                 numeroPatinhosAtual--)
            {
                if (numeroPatinhosAtual > 1)
                {
                    Console.WriteLine($"\n{numeroPatinhosAtual} patinhos foram passear");
                }
                else
                {
                    Console.WriteLine($"\n{numeroPatinhosAtual} patinho foi passear");
                }
                
                Console.WriteLine($"Além das montanhas");
                Console.WriteLine($"Para brincar");
                Console.WriteLine($"A mamãe gritou: Quá, quá, quá, quá");

                if (numeroPatinhosAtual > 2)
                {
                    Console.WriteLine($"Mas só {numeroPatinhosAtual - 1} patinhos voltaram de lá.");   
                }
                else if (numeroPatinhosAtual > 1)
                {
                    Console.WriteLine($"Mas só {numeroPatinhosAtual - 1} patinho voltou de lá.");
                }
                else
                {
                    Console.WriteLine($"Mas nenhum patinho voltou de lá.");
                }       
            }

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            
            Console.WriteLine($"\n\nA mamãe patinha foi procurar");
            Console.WriteLine($"Além das montanhas");
            Console.WriteLine($"Na beira do mar");
            Console.WriteLine($"A mamãe gritou: Quá, quá, quá, quá");
            Console.WriteLine($"E os {totalNumeroPatinhos} patinhos voltaram de lá.");   

            Console.ForegroundColor = corPadrao;  
        }
    }
}
