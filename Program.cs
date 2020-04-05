using System;
using System.Globalization;

namespace excclasses004
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();

            Console.WriteLine("Entre a Largura e altura do retangulo: ");
            p.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            p.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Area =" + p.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perimetro = " + p.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal = " + p.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
    
        }
    }
}
