using System.ComponentModel.Design;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*16. Escribe un algoritmo en el que el ordenador elija un número aleatorio entre 1 y 100. El usuario debe adivinar el número, 
             * y el programa debe decirle si su intento es demasiado alto, demasiado bajo o correcto. 
             * Usa un ciclo while para seguir pidiendo intentos hasta que el usuario adivine el número. */
            int numero;
            int Elegido = 0;
            int contador = 0;
            Random nrd = new Random();
            numero = nrd.Next(1, 100);
            do {
                Console.WriteLine($"Intento {contador + 1}:Adivina el numero");
            Elegido=Convert.ToInt32(Console.ReadLine());
                if (numero > Elegido)
                {
                    Console.WriteLine("Es muy pequeño");
                }
                else if (numero < Elegido)
                {
                    Console.WriteLine("Es muy grande");
                }
                else if(Elegido == numero)
                {
                    Console.WriteLine("Correcto");
                }
                    contador++;
                }while(Elegido!=numero);
            Console.WriteLine($"Felicidades {numero} es el numero correcto ");
    }
    }
}

