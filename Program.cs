using System;

namespace Sinal
{
    class Program
    {
        static void Main(string[] args)
        {
            double num, den, div;

            Console.Write("Digite o numerador:");
            num = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o denominador:");
            den = Convert.ToDouble(Console.ReadLine());

            div = num / den;
            if(den == 0)
            {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Não é possível dividir por zero");
            Console.ResetColor();
            }
            else
            {
                Console.WriteLine($"{num} dividido por {den} é {div}");           
                 


            }    
        }
    }
}
