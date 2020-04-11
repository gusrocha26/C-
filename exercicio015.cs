using System;

namespace exercicio014
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;


            Console.Write("Entre com o número da conta:");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titula da conta:");
            string titular = Console.ReadLine();
            Console.WriteLine("Haverá depósito inicial (s/n)?");
            char resp = char.Parse(Console.ReadLine());
            if(resp == 's' || resp== 'S')
            {
                Console.Write("Entre com valor de deposito inicial:");

            }

           

           

        }
    }
}
