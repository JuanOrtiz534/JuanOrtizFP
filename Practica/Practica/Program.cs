using System.Numerics;

namespace Practica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int filas = 0;
            int columnas = 0;

            Console.WriteLine("Cuantas filas?");
            filas= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("cuantas columnas?");
            columnas = Convert.ToInt32(Console.ReadLine());
            int[,] matriz = new int[filas,columnas];

            int[] contador = new int[4];
            Random rnd = new Random();
            for(int i = 0; i < filas; i++)
            {
                for(int j = 0; j < columnas; j++)
                {
                    matriz[i, j] = rnd.Next(0, 4);
                }
            }
            for(int i = 0;i < filas;i++)
            {
                for( int j = 0;j < columnas;j++)
                {
                    Console.WriteLine($"Matriz= {matriz[i,j]}");
                }
                Console.WriteLine();
            }
             for(int i = 0;i < filas;i++)
            {
                for (int j = 0;j<columnas;j++)
                {
                    int numero = matriz[i,j];
                    contador[numero]++;
                }
            }
            for (int k = 0; k <= 3; k++) 
            {
                Console.WriteLine($"El numero {k, 2} apararece {contador[k]}");
            }

        }

    }
}

