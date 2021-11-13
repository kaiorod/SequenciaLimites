using System;
using System.Threading;

namespace SequenciaLimites
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, c;

            Console.Write("Entre com o primeiro valor : ");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("Entre com o segundo valor : ");
            n2 = int.Parse(Console.ReadLine());

            c = n1;
            if(n1 > n2 || n1 == n2)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("Erro!! O primeiro número tem que ser o maior");
                Console.ResetColor();
            }
            else
            {
                while(c <= n2)
                {
                    Thread.Sleep(50);
                    Console.Write($" {c}");
                    c++;
                }
            }
        }
    }
}
