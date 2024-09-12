/*
*Questão escolhida: As maçãs custam R$ 0,30 cada se forem compradas menos do que uma
*dúzia, e R$ 0,25 se forem compradas pelo menos doze. Escreva um
*programa que leia o número de maçãs compradas, calcule e escreva o
*valor total da compra.
*
*Estrutura escolhida: if/else
*/

namespace quizSemana3
{
    internal class Program{
        static void Main(string[] args){
            //Criando as variáveis
            int quantMacas;
            double total;

            Console.WriteLine("Insira quantas maçãs você deseja comprar: ");
            quantMacas = int.Parse(Console.ReadLine());

            if(quantMacas < 12)
            {
                total = quantMacas * 0.30;
            }
            else
            {
                total = quantMacas * 0.25;
            }

            Console.WriteLine("Você comprou " + quantMacas + " e vai pagar: " + total + ".");
        }
    }
}
