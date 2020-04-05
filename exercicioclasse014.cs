using System;
using System.Collections.Generic;
using System.Text;

namespace excclasses004
{
    class Pessoa
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return 2 * (Altura + Largura);
        }
        public double Diagonal()
        {
            return Math.Sqrt(Altura * Altura + Largura * Largura);
        }




    }
}
