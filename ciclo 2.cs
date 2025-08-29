namespace _Ciclo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int contador = 1;
            int acumulador = 1;

            Console.WriteLine("Ingrese un número");
            num = int.Parse(Console.ReadLine());


            while (contador <= num)
            {
                acumulador = acumulador * contador;
                Console.WriteLine($"Contador:{contador} - Factorial:{acumulador}");
                contador++;
            }
            Console.WriteLine($"El factorial de {num} es {acumulador}");
        }
    }
}

