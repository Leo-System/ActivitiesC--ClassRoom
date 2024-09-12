namespace QuizSemana4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[10];

            try
            {
                Console.WriteLine(vetor[10]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
