using System;
using System.Globalization;

namespace EstruturaWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');

            int X = int.Parse(valores[0]);

            int Y = int.Parse(valores[1]);

            while (X != Y)
            {
                if (X < Y)
                {
                    Console.WriteLine("Crescente");
                }
                else
                {
                    Console.WriteLine("Descrescente");
                }

                valores = Console.ReadLine().Split(' ');

                X = int.Parse(valores[0]);

                Y = int.Parse(valores[1]);
            }
        }
    }
}
