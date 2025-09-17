namespace _22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //arreglos Inidimensionales
            //Vectores
            int[] numeros = new int[5];
            string[] nombres = new string[4];
            //Almacenemos datos
            numeros[0] = 12;
            numeros[1] = 15;
            numeros[2] = 22;
            numeros[3] = 53;
            numeros[4] = 92;
            //numeros[5]=0; no se puede guardar pues estaria fuera del rango
            //recuperar dato
            Console.WriteLine($"Valor de posición 4 con indecie 3 es {numeros[3]}");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Ingrese el dato de la posición {1 + i}; con índice {i}");
                numeros[i] = int.Parse(Console.ReadLine());
            }
            //otras formas de declarar e inicializar vectores
            char[] caracteres = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g' };
            float[] numeros2 = { 0.3f, 1.5f, 2.5f, 4.5f, 0.0f };

            //Recorrer para recuperar datos almacenados

            for (int i = 0; i < caracteres.Length; i++)
            {
                Console.WriteLine($"P:{i + 1}-I:{i}:{caracteres[i]}");
            }
            for (int i = 0; i < numeros2.Length; i++)
            {
                Console.WriteLine($"{numeros2[i]}|");
            }

            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine($"Ingrese los nombre de la posición {i + 1}; con indice {i}");
                nombres[i] = Console.ReadLine();
                Console.WriteLine($"Nombre:{nombres[i]}");
            }
        }
    }
}
