using System;
using System.Globalization;

namespace exercicio012
{
    class Program
    {
        static void Main(string[] args)
        {

            Funcionarios dadosFunc = new Funcionarios();

            Console.Write("Nome :");
            dadosFunc.Nome = Console.ReadLine();
            Console.Write("Salario Bruto: ");
            dadosFunc.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Impostos:");
            dadosFunc.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine("Funcionarios:" + dadosFunc);

            Console.WriteLine();
            Console.WriteLine("Deseja aumentar o salario em qual porcentagem ?");
            double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            dadosFunc.AumentarSalario(porcent);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + dadosFunc);







            
            

        }
    }
}
