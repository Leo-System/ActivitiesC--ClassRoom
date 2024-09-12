char resp = ' ';
while (resp != 'N'){
    Console.Clear();

    Console.Write("Entre com a nota da prova 1: ");
    float notap1 = float.Parse(Console.ReadLine());

    Console.Write("Entre com o peso da p1: ");
    float peso1 = float.Parse(Console.ReadLine());
    
    Console.Write("Entre com a nota da prova 2: ");
    float notap2 = float.Parse(Console.ReadLine());

    Console.Write("Entre com o peso da p2: ");
    float peso2 = float.Parse(Console.ReadLine());

    Console.Write("Entre com o nota da quiz: ");
    float notaQuiz = float.Parse(Console.ReadLine());
    
    Console.Write("Entre com o peso da quiz: ");
    float pesoQuiz = float.Parse(Console.ReadLine());

    float media = ((notap1 * peso1) + (notap2 * peso2) + (notaQuiz * pesoQuiz) / (peso1 + peso2 + pesoQuiz));

    Console.WriteLine(string.Format("A media final é: {0:F2}", media));
    while (true){
        Console.Write("\n\n\t\tDigite 'S' para sim e 'N' para não: ");
        string input = Console.ReadLine().ToUpper();

        if (input.Length == 1 && (input[0] == 'S' || input[0] == 'N')){
            resp = input[0];
            break;
        }
        else
       // {
            Console.WriteLine("Entrada Inválida, apenas digite 'S' ou 'N'!");
       // }
    }
}
