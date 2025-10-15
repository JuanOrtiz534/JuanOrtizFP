namespace Supletorio_parcial_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int venta = 0;
            int sumadeventa = 0;
            int mes = 0;
            int mayor = 0;
            int promedio = 0;
            int menor = 999999999;
            int contador = 0;
            int mayormes = 0;
            int menormes = 0;
            do
            {
                Console.WriteLine($"Por favor ingrese el numero de ventas del mes {mes++ +1}");
                venta=Convert.ToInt32( Console.ReadLine() );
                sumadeventa=venta+sumadeventa;
                if (venta > mayor)
                {
                    mayor = venta;
                    mayormes = mes;
                }
                if (venta < menor)
                {
                    menor= venta;
                    menormes = mes;
                }
                contador++;
           
            } while (contador < 12);
           promedio = sumadeventa/contador;
            Console.WriteLine($"El mes con mayores ventas fue {mayormes} y el de menor numero fue {menormes}");
            if (promedio >500)
            {
                Console.WriteLine($"El promedio de {promedio} aprueba la meta");
            }
            else if(promedio <= 500)
            {
                Console.WriteLine($"El promedio de {promedio} no aprueba la meta");
            }

        }
    }
}
