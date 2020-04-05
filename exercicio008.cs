using System;
using System.Globalization;

namespace excercicio008
{
    class pessoas
    {
        public string nome;
        public double salario;
    }
}





namespace excercicio008
{
    class Program
    {
        static void Main(string[] args)
        {
            pessoas p1 = new pessoas();
            pessoas p2 = new pessoas();

            Console.WriteLine("Dados do primeiro funcionario:");
            Console.Write("Nome:");
            p1.nome = Console.ReadLine();
            Console.Write("salario:");
            p1.salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture );


            Console.WriteLine("Dados do segundo funcionario:");
            Console.Write("Nome:");
            p2.nome = Console.ReadLine();
            Console.Write("Salario:");
            p2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double media =  (p1.salario + p2.salario) / 2.0;

            Console.WriteLine("Salario medio = " + media.ToString("F2", CultureInfo.InvariantCulture));
                
        }
    }
}
