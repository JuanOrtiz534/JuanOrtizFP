using System;

namespace _13.hile;

internal class Program
{
    static void Main(string[] args)
    {
        //Escribir un algoritmo que cuente cuántos números pares hay en un rango de números deñ 1 al número n.
        int rango = 0;
        int Npares = 0;
        int contador = 1;
        Console.WriteLine("Ingrese rango");
        rango = int.Parse(Console.ReadLine());

        while (contador <= rango)
        {
            if (contador % 2 == 0)
            {
                Npares++;
            }
            contador++;
        }
        Console.WriteLine($"La cantidad de números pares del 1 hasta {rango}, es:{Npares}");

        /*Realizar un algortimo que le pida al usuario ingresar por teclado números enteros al azar. Al usuario le corresponde ingresar la cantidad de números que va a introducir
         El algoritmo debe escribir en pantalla:
        1.La cantidad de números introducidos que son mayores que 0.
        2.La cantidad de números introducidos menores que 0.
        3.La cantidad de números iguales a 0.*/
        int Contador = 0;
        int Numero = 0;
        int mayor = 0;
        int menor = 0;
        int igual = 0;
        int Cantidad = 0;
        Console.WriteLine("Ingrese LA CANTIDAD de numeros");
        Cantidad = int.Parse(Console.ReadLine());
        while (contador <= Cantidad)
        {
            Console.WriteLine($"Ingrese # {Contador + 1}");
            Numero = int.Parse(Console.ReadLine());
            if (Numero > 0)
            {
                mayor++;
            }
            else if (Numero < 0)
            {
                menor++;
            }
            else if(Numero == 0) 
            {
                igual++;
            }
            Contador++;
        }
        Console.WriteLine($"Numeros positivos:{mayor}, numeros negativos:{menor} y numeros 0 :{igual}");
    }
}
