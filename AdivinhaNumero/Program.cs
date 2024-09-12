int n, escolha = 0, cont = 0;

Random segredo = new Random();

n = Convert.ToInt32(segredo.Next(1,10));

Console.WriteLine("**** JOGO DA ADVINHÇÂO *****");
Console.WriteLine("Advinhe o numero secreto");
Console.WriteLine("Dica, numero de 1 a 10");

try
{
    while (escolha != n)
    {
        escolha = Convert.ToInt32(Console.ReadLine());

        if (escolha > 0)
        {
            Console.WriteLine("ERRADO! O número é menor");
        }
        else if (escolha > n)
        {
            Console.WriteLine("ERRADO! O número é maior");
        }
        else if (escolha == n && cont == 0)
        {
            Console.WriteLine("Você acertou de primeira!");
        }else if (escolha > n){
            Console.WriteLine("Número muito grande.");

        }else
        {
            Console.WriteLine("Você acertou!");
        }
        cont++;
    }

    Console.WriteLine("Total de tentativas: " + cont);
    Console.ReadKey();
}catch {
    Console.WriteLine("Você perdeu!");
    Console.WriteLine("Não deixe em branco e digite apenas números!");
    Console.ReadKey();
}
