namespace Taller_de_preparación_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nota = 0;
            int contador =0;
            int promedio = 0;
            bool deseo = false;
            char respuesta;
            int acumulador = 0;

            do
            {
                Console.WriteLine($"cual es la nota {contador + 1} ");
                nota = int.Parse(Console.ReadLine());
                acumulador = acumulador + nota;
                Console.WriteLine("¿Quiere procegri colocando notas o desea parar?: p=parar c=continuar");
                respuesta = Convert.ToChar(Console.ReadLine());
                if (respuesta=='p')
                {
                    deseo = false;
                }
                else
                {
                    deseo= true;
                }
                contador++;


            } while (deseo = true);
            promedio = acumulador/contador;
            Console.WriteLine($"tu promedio es de {promedio}");
        }
    }
}
