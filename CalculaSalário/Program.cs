using System.Runtime.InteropServices;

string[] historico = new string[10];
int indiceHistorico = 0;

while (true)
{
    Console.Clear();
    Console.WriteLine("\n\n\n\t\t\t\t\t\tM E N U");
    Console.ReadKey();
    Console.WriteLine("Presione F1 para calcular o salário líquido: ");
    Console.WriteLine("Presione F2 para calcular o 13 salário: ");
    Console.WriteLine("Presione F3 para exibir o histórico de salários: ");
    Console.WriteLine("Presione DEL para sair.");
    ConsoleKeyInfo tecla = Console.ReadKey(true);

    if (tecla.Key == ConsoleKey.F1)
    {
        Console.Clear();
        Console.WriteLine("Digite o valor da hora trablhada: ");
        double valorHora = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o número de horas trabalhadas: ");
        double horasTrabalhadas = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o desconto total (em %): ");
        double desconto = Convert.ToDouble(Console.ReadLine());

        double salarioBruto = valorHora * horasTrabalhadas;
        double salarioLiquido = salarioBruto * (1 - desconto / 100);

        Console.WriteLine($"O salário bruto é: R$ {salarioBruto:F2}");
        Console.WriteLine($"O salário líquido é: R$ {salarioLiquido:F2}");

        Console.ReadKey();

        if(indiceHistorico == historico.Length)
        {
            historico[indiceHistorico] = $"Salário Líquido : R$ {salarioLiquido:F2}";
            indiceHistorico++;
        }
        Console.WriteLine("Pressione qualquer tecla para continuar: ");
        Console.ReadKey();
    }//Essa chave fecha o consoleKey.F1
    else if(tecla.Key = ConsoleKey.F2)
    {
        Console.Clear();
        Console.WriteLine("Digite o salário bruto: ");
        double salarioBruto = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite a quantidade de meses trabalhados: ");
        int mesesTrabalhados = Convert.ToInt32(Console.ReadLine());

        //Garantindo que os meses trabalhados estejam entre 1 e 12
        if(mesesTrabalhados < 1 || mesesTrabalhados > 12)
        {
            Console.WriteLine("Numero de meses inválidos, coloque entre 1 e 12!");
            Console.WriteLine("Aperte qualquer tecla para seguir.");
            Console.ReadKey();
            continue;
        }
        double decimoTerceiro = (salarioBruto / 12)

        Console.WriteLine("Digite o salário bruto: ");
        double salarioBruo = Convert.ToDouble(Console.ReadLine());

        if(indiceHistorico < historico.length)
        {
            historico[indiceHistorico] = $"13 Salario ";
        }


        Console.WriteLine("Pressione qualquer tecla para continuar: ");
        Console.ReadKey();
    }//Esta chave fecha o F2

    else if(tecla.Key == ConsoleKey.F3)
    {
        Console.Clear();
        Console.WriteLine("Histórico de calculos realisados");
       
        if(indiceHistorico == 0)
        {
            Console.WriteLine("Nenhum Calculo Realisado");
        }
        else
        {
            for(int i = 0; i < indiceHistorico; i++)
            {
                Console.WriteLine(i + 1 , "Historico: ", historico[i]);
            }
        }

        Console.WriteLine("Pressione qualquer tecla para continuar: ");
        Console.ReadKey();
    }

    else if(tecla.Key == ConsoleKey.Delete)
    {
        Console.WriteLine("Saindo....");
        break;
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Opção inválida! Tente novamente...");
        Console.WriteLine("Pressione qualquer tecla para continuar: ");
        Console.ReadKey();
    }
}