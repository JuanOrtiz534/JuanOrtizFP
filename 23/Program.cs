using System;

namespace _23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*23. Crear arreglo llamado "numeros" de 100 elementos asignar el número 10 en cada una de las posiciones del arreglo. Leer el contenido de cada elemento y escribirlo en pantalla.*/
            int[] numero= new int[100];
            for(int i = 0; i < numero.Length; i++) {
                numero[i]= 10;
                Console.WriteLine($"P:{i + 1}-I:{i}:{numero[i]}");
                    }
        }
    }
}
