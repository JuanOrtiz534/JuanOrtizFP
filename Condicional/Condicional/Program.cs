using System.Security.Cryptography;
using System.Text;

namespace Condicional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Tiendas La Avenida desea desarrollar un programa que permita ingresar por teclado el monto de compra y el día de la semana, para saber:
            Si el día es martes o jueves, se realizará un descuento del 15 % por la compra. 
Si el día es lunes o miércoles, se realizará un descuento del 10 % por la compra.
Si el día es viernes o sábado, se realizará un descuento del 20 % por la compra.
Si es domingo no se realiza descuento.
Visualizar el día, el descuento y el total a pagar por la compra*/

            float valorcompra = 0;
            float descuento = 0;
            char dia = ' ';

            Console.WriteLine("Ingrese el valor de la compra");
            valorcompra = Single.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el día de la semana: l:lunes, m:martes, x:miércoles, j:jueves, v:viernes, s:sábado, d:domingo");
            dia = Convert.ToChar(Console.ReadLine());

            switch (dia)
            {
                case 'l':
                    descuento = valorcompra * 0.1f;
                    Console.WriteLine($"Hoy es lunes, descuento: {descuento}, valor a pagar: {valorcompra - descuento}");
                    break;
                case 'm':
                    descuento = valorcompra * 0.15f;
                    Console.WriteLine($"Hoy es martes, descuento: {descuento}, valor a pagar: {valorcompra - descuento}");
                    break;
                case 'x':
                    descuento = valorcompra * 0.1f;
                    Console.WriteLine($"Hoy es miercoles, descuento: {descuento}, valor a pagar: {valorcompra - descuento}");
                    break;
                case 'j':
                    descuento = valorcompra * 0.15f;
                    Console.WriteLine($"Hoy es jueves, descuento: {descuento}, valor a pagar: {valorcompra - descuento}");
                    break;
                case 'v':
                    descuento = valorcompra * 0.2f;
                    Console.WriteLine($"Hoy es viernes, descuento: {descuento}, valor a pagar: {valorcompra - descuento}");
                    break;
                case 's':
                    descuento = valorcompra * 0.2f;
                    Console.WriteLine($"Hoy es sábado, descuento: {descuento}, valor a pagar: {valorcompra - descuento}");
                    break;
                case 'd':
                    descuento = valorcompra * 0f;
                    Console.WriteLine($"Hoy es domingo, descuento: {descuento}, valor a pagar: {valorcompra - descuento}");
                    break;
                default:
                    Console.WriteLine("Debe ingrear valor valido");
                    break;

            }
            /*Diseñar un algoritmo que permita crear una calculadora básica capaz de realizar operaciones aritméticas entre dos números ingresados por el usuario.Las operaciones disponibles serán: suma, resta, multiplicación y división, las cuales se ejecutarán según la opción seleccionada por el usuario.*/
            float N1 = 0;
            float N2 = 0;
            char operación;

            Console.WriteLine("Ingrese el valor de N1");
            N1 = Single.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de N2");
            N2 = Single.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tipo de operacion: S:suma, R:resta, D: división, M: multiplicación");
            operación = Convert.ToChar(Console.ReadLine());
            switch (operación)
            {
                case 'S':
                    Console.WriteLine($"El valor la suma es: {N1 + N2}");
                    break;
                case 'R':
                    Console.WriteLine($"El valor la resta es: {N1 - N2}");
                    break;
                case 'M':
                    Console.WriteLine($"El valor la multiplicación es: {N1 * N2}");
                    break;
                case 'D':
                    Console.WriteLine($"El valor la divición es: {N1 / N2}");
                    break;
                default:
                    Console.WriteLine("Debe ingrear valor valido");
                    break;
            }
            }
    }
}
