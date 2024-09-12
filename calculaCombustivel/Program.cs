float tempo = 0, vm = 0, distancia = 0, litros = 0;

Console.Clear();

Console.WriteLine("Entre com o tempo gasto: ");
tempo = float.Parse(Console.ReadLine());

Console.WriteLine("Entre com a velocidade media: ");
vm = float.Parse(Console.ReadLine());

Console.Clear();

distancia = tempo * vm;

/* Este calculo acima assume que o veículo consome um litro de combustivel para
 * cada 12 kilometros percorridos
 */

litros = distancia / 12;

Console.Beep();
Console.WriteLine("Sua velocidade média foi de " + vm + " Km/h.");
Console.WriteLine("O tempo gasto foi de " + tempo + " horas.");
Console.WriteLine("A distancia percorrida foi de " + distancia + " Km.");
Console.WriteLine("Foram utilizados " + litros + " litros.");
Console.ReadKey();