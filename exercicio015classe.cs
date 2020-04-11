using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio014
{
    class ContaBancaria

    {

        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        
        
        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;


        }

        public ContaBancaria( int numero, string titular, double saldo) : this(numero, titular)
        {
            Saldo = saldo;
        }







    }
}
