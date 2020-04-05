using System;

namespace ExcCondc001
{
    class Program
    {
        static void Main(string[] args)
        {

            int numb = int.Parse(Console.ReadLine());
             if (numb % 2 == 0)
            {
                Console.WriteLine("Par");

            }
             else
            {
                Console.WriteLine("Impar");
            }



        }
    }
}
