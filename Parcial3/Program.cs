using System.Security.Cryptography;

namespace Parcial3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int filas = 0;
            int columnas = 0;
            int valides = 0;
            int valides2 = 0;
            int resultado = 0;
            char operación;
            do
            {
                Console.WriteLine("Cuantas filas?");
                filas = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Cuantas columnas?");
                columnas = Convert.ToInt32(Console.ReadLine());

                if (filas >= 2 && filas <= 10)
                {
                    if (columnas >= 2 && columnas <= 10)
                    {
                        Console.WriteLine("Valores validos");
                        valides = 1;
                    }
                }
                else
                {
                    Console.WriteLine("Error");
                }
            } while (valides != 1);
            int[,] matriz = new int[filas, columnas];
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    do
                    {
                        Console.WriteLine($"Ingresa {i},{j}");
                        matriz[i, j] = Convert.ToInt32(Console.ReadLine());

                        if (matriz[i, j] > 1000 || matriz[i, j] < -1000)
                        {
                            Console.WriteLine($"repite {i},{j}");
                            matriz[i, j] = Convert.ToInt32(Console.ReadLine());
                            valides2 = 4;
                        }

                    } while (valides2 == 1);
                }
            }
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.WriteLine($"{i},{j} | {matriz[i, j],5}");
                }
            }
            do
            {
                int k = 0;
                int c = 0;
                int w = 0;
                int l = 0;
                
                Console.WriteLine("Que decias hacer? sumar=s, restar=r, dividir=d o multi=m");
                operación=Convert.ToChar(Console.ReadLine());

                switch (operación)
                {
                    case 's':

                        Console.WriteLine($"ingrese cordenada 1");
                        k = Convert.ToInt32(Console.ReadLine());
                        c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"ingrese cordenada 2");
                        w = Convert.ToInt32(Console.ReadLine());
                        l = Convert.ToInt32(Console.ReadLine());
                        int cordenada1 = 0;
                        int cordenada2 = 0;
                        cordenada1 = matriz[k, c];
                        cordenada1 = matriz[w, l];
                        resultado = cordenada1 + cordenada2;
                        Console.WriteLine($"{cordenada1} + {cordenada2} = {resultado}");

                        break;
                    case 'r':

                        Console.WriteLine($"ingrese cordenada 1");
                        k = Convert.ToInt32(Console.ReadLine());
                        c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"ingrese cordenada 2");
                        w = Convert.ToInt32(Console.ReadLine());
                        l = Convert.ToInt32(Console.ReadLine());
                        int cordenada4 = 0;
                        int cordenada3 = 0;
                        cordenada1 = matriz[k, c];
                        cordenada1 = matriz[w, l];
                        resultado = cordenada4 - cordenada3;
                        Console.WriteLine($"{cordenada4} - {cordenada3} = {resultado}");

                        break;
                    case 'm':

                        Console.WriteLine($"ingrese cordenada 1");
                        k = Convert.ToInt32(Console.ReadLine());
                        c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"ingrese cordenada 2");
                        w = Convert.ToInt32(Console.ReadLine());
                        l = Convert.ToInt32(Console.ReadLine());
                        int cordenada5 = 0;
                        int cordenada6 = 0;
                        cordenada1 = matriz[k, c];
                        cordenada1 = matriz[w, l];
                        resultado = cordenada5 * cordenada6;
                        Console.WriteLine($"{cordenada5} * {cordenada6} = {resultado}");

                        break;


                    default:
                        Console.WriteLine("Debe ingrear valor valido");
                        break;
                }




        }
    }
}
