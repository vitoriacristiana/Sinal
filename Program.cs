using System;

namespace Sinal
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Digite um número:");
            n=Convert.ToInt32(Console.ReadLine());

             if (n < 0)
            {
                Console.ForegroundColor=ConsoleColor.DarkRed;
                Console.WriteLine("Negativo");
                Console.ResetColor();

                }
            else if (n == 0)
            {
                Console.WriteLine("Zero");
            }
            else if (n > 0)
            {
                Console.ForegroundColor=ConsoleColor.DarkGreen;
                Console.WriteLine ("Positivo");
                Console.ResetColor();
            }    
        }
    }
}
