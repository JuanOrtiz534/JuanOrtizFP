namespace _26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] Num1 = new int[2, 3];
            int[,] Num2 = new int[2, 3];
            int[,] Sum = new int[2, 3];

            for (int i = 0; i < 3; i++) //Recorrer las filas
            {
                for (int j = 0; j < 2; j++)//Recorrer las columnas
                {
                    Console.WriteLine($"Digite el numero 1 {i},{j}:");
                    Num1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
    }
}
