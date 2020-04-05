using System;

namespace ExcEnt006
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb = int.Parse(Console.ReadLine());
               if (numb < 0)
            {
                Console.WriteLine("NEGATIVO");
            }
               else
            {
                Console.WriteLine("NAO NEGATIVO");
            }

        }
    }
}
