namespace _15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*15. Realizar un algoritmo para determinar cuánto ahorrará una persona en un año, 
             * si al final de cada mes deposita cantidades variables de dinero; además, se quiere saber cuánto lleva ahorrado cada mes. */
            int contador = 0;
            int ahorro = 0;
            int ahorrototal = 0;
            int dinero =0;

            do
            {
                Console.WriteLine($"Ingrese el dinero el més {contador + 1}");
                dinero = Convert.ToInt32(Console.ReadLine());
                ahorro = dinero + ahorro;
                ahorrototal += ahorro;
                Console.WriteLine($"Llevas {ahorro} ahorrado");
                contador++;
            } while (contador < 12 );
            Console.WriteLine($"A lo largo del año ahorraste {ahorrototal}");

        }
    }
}
