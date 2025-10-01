namespace Taller_matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] numeros = new int[5, 6];
            for (int i = 0; i < 5;i++)
            {
                for(int j = 0; j < 6;j++)
                {
                    Console.WriteLine($"Digite el numero 1 {i},{j}:");
                    numeros[i, j] = Convert.ToInt32(Console.ReadLine());
                    if (j!=j++)
                    {
                        numero

                    }
                }
            }
            
        }
    }
}
