using System;

namespace TreinoPessoal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta con = new Conta();

            con.exibe();

            con.setNome("Juãû");
            con.setAgencia(9163);
            con.setNumero(1242);
            con.setSaldo(195.87);

            Console.WriteLine("\n");

            con.exibe();
        }
    }
}
