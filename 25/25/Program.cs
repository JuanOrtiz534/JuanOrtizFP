namespace _25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arreglos bidimensionales  - matrices
            int[,] numeros = new int[2,2];// rango = fxc=2x2=4
            string[,] nombres = new string[3,2];
            char[,] caracteres = new char[2,4];
            bool[,] banderas = new bool[2,5];
            object[,] objetos = new object[2,5];

            //Asignación de valores con f , c

            numeros[0, 0] = 15;
            numeros[0, 1] = 25;
            numeros[1, 0] = 32;
            numeros[1, 1] = 7;
            //numeros[1, 2]=5; No es posible, fila y colupna deben estar en el rango


            //Recuperar datos almacenados en una posición

            Console.WriteLine($"Valor alamcenado en la posición de indice 1,0 {numeros[1,0]}");

            //declaración e inicializacvión de matrices con valores por defecto

            string[,] apellidos =
                {
                {"Chica","López","Álvarez"},
                {"Patiño","Cito","Botero"},
                {"Duque","Carmona","Castaño"}
                };

            //Recorrer para almacenar datos

            for(int i = 0; i<3 ; i++ ) //Recorrer las filas
            {
                for(int j = 0; j< 2 ; j++ )//Recorrer las columnas
                {
                    Console.WriteLine($"Digite el nombre para almacenarlo en la posición con índices {i},{j}:");
                    nombres[i, j] = Console.ReadLine();
                }
            }

            //recorrer para recuperar sus datos

            for(int i = 0; i <nombres.GetLength(0); i++ ) //GetLength(0) debuelve el numero de la filas
            {
                for (int j = 0; j < nombres.GetLength(1); j++) //GetLength(0) debuelve el numero de la columnas
                {
                    Console.WriteLine($"Nombres almacenados en posición {i},{j}: {nombres[i,j]}");
                }

            }
            for (int i = 0; i < nombres.GetLength(0); i++) //GetLength(0) debuelve el numero de la filas
            {
                for (int j = 0; j < nombres.GetLength(1); j++) //GetLength(0) debuelve el numero de la columnas
                {
                    Console.Write($"{nombres[i, j]}   |");
                }
                Console.WriteLine();

            }
        }
    }
}
