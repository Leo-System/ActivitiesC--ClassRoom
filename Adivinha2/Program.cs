using System.ComponentModel;

namespace Adivinha2

{
    internal class Program
    {
        static int sorteio(int senha)
        {
            Random n = new Random();
            senha = Convert.ToInt32(n.Next(1, 10));
            return senha;
        }

        static void dicas(int number, int password, int attempt)
        {
            if(number > password)
            {
                Console.WriteLine($"O número é menor que {number}");
            }else if(number < password)
            {
                Console.WriteLine($"O número é maior que {number}");
            }
            else
            {
                Console.WriteLine($"Parabéns! Você acertou o número em {attempt} tentativas!");
            }
        }

        //Main
        static void Main(string[] args)
        {
            int continuar = 1, password = 0, attempt = 0, number = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("Sorteando número entre 1 e 10.");
                password = sorteio(password);
                Console.WriteLine("Começou o jogo, tente adivinhar o número.");
                attempt = 0;

                do
                {
                    attempt++;
                    Console.WriteLine($"Tentativa n {attempt}");
                    Console.WriteLine("Digite um número: ");
                    number = int.Parse(Console.ReadLine());
                    dicas(number, password, attempt);
                } while (number != password);

                Console.WriteLine("Digite 0 para sair o qualquer outro número para continuar: ");
                try {
                    continuar = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    continuar = 1;
                }
            } while (continuar != 0);


        }

    }
}
