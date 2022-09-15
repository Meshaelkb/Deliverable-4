// Meshael Albulaihed
// 09/15/2022



namespace Deliverable_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] fibonacci = new int[25];
            fibonacci[0] = 0;
            fibonacci[1] = 1;
            for (int i = 0; i < 25; i++)
            {
                if (i >= 2)
                {
                    fibonacci[i] = fibonacci[i - 2] + fibonacci[i - 1];
                }
                Console.WriteLine(fibonacci[i]);
            }
        }
      
}

}