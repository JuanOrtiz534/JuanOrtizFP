namespace _18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*18. Algoritmo que le pida a un grupo de usuarios su nombre, número de cuenta y saldo; para cada usuario se debe hacer lo siguiente: 
Si el saldo es mayor a 3’000.000, sacar un mensaje que diga el nombre del usuario, el número de cuenta, el saldo y “Es apto para el crédito” 
Si el saldo es menor a 3’000.000, sacar un mensaje que diga el nombre del usuario, el número de cuenta, el saldo y “No es apto para el crédito” 
El algoritmo debe permitir preguntar la información de usuarios, hasta que se le indique que ya no se desea preguntar más. 
Además, el algoritmo debe permitir mostrar el número de usuarios a los que se le pregunto por la información, y debe mostrar el promedio de los saldos. */

            int contador = 0;
            int saldo = 0;
            int saldototal =0;
            int cuenta = 0;
            string nombre;
            char deseo;
           

            do
            {
                Console.WriteLine("¿Cual es su nombre?");
                nombre = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Dar numero de cuenta");
                cuenta = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Saldo?");
                saldo = Convert.ToInt32(Console.ReadLine());
                saldototal = saldo + saldototal;
                if (saldo >= 3000000)
                {
                    Console.WriteLine($"Sr/a {nombre} de cuenta {cuenta} con saldo de {saldo}, nos alegra decirle que usted es apto/a para el credito");
                }
                else
                {
                    Console.WriteLine($"Sr/a {nombre} de cuenta {cuenta} con saldo de {saldo}, lamentamos informarle que usted no es apto/a para el credito");
                }
                Console.WriteLine("¿Hay otro usuario? s=si n=no");
                deseo = Convert.ToChar(Console.ReadLine());
                if (deseo == 's' || deseo == 'S')
                {
                    Console.WriteLine("Ok,empezemos");
                }
                contador++;
            } while (deseo != 'n');
            Console.WriteLine($"Fuerón un total de {contador} usuarios, y el promedio de los saldos fue {saldototal / contador}");

    }
    }
}
