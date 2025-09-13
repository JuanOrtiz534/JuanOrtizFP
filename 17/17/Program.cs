namespace _17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*17. Algoritmo que solicita un número y genere su correspondiente tabla de multiplicar desde el 1 hasta el 10. 
             * Y así sucesivamente hasta que el usuario ya no desee continuar generando tablas de multiplicar.*/
            int contador = 0;
            int numero;
            char deseo;
            do
            {
                Console.WriteLine($"Tabla {contador + 1}: ¿cual desea?");
                numero = Convert.ToInt32( Console.ReadLine() );
                Console.WriteLine($"{numero}x1={numero * 1}" );
                Console.WriteLine($"{numero}x2={numero * 2}");
                Console.WriteLine($"{numero}x3={numero * 3}");
                Console.WriteLine($"{numero}x4={numero * 4}");
                Console.WriteLine($"{numero}x5={numero * 5}");
                Console.WriteLine($"{numero}x6={numero * 6}");
                Console.WriteLine($"{numero}x7={numero * 7}");
                Console.WriteLine($"{numero}x8={numero * 8}");
                Console.WriteLine($"{numero}x9={numero * 9}");
                Console.WriteLine($"{numero}x10={numero * 10}");
                Console.WriteLine("¿Desea hacer otra tabla? s=si n=no");
                deseo=Convert.ToChar( Console.ReadLine() );
                if (deseo == 's')
                {
                    Console.WriteLine("Siguiente");
                }
                contador++;

            } while (deseo != 'n');
            Console.WriteLine("Esta bien");
        }
    }
}
