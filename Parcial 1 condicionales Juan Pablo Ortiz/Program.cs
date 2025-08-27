using System.Security.Cryptography;

namespace Parcial_1_condicionales_Juan_Pablo_Ortiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad = 0; 
            char Sala = ' ';
            char juego = ' ';
            float valor = 0;
            Console.WriteLine("Por favor indicar su edad.");
            edad = Int32.Parse(Console.ReadLine());

            if (1 < edad && edad <= 5) ;
            {
                Console.WriteLine("Puedes ir a sala 1");
            }
          if (6 < edad && edad <= 16) ;
            {
                Console.WriteLine("Puedes ir a sala 1 y 2");
            }
            if (17 < edad && edad <= 25) ;
            {
                Console.WriteLine("Puedes ir a sala 1, 2, 3 y 4");
            }
            if (edad < 25) ;
            {
                Console.WriteLine("Puedes ir a todas las salas");
            }
            Console.WriteLine("Segun el rango de edad elige tu sala: sala 1: a, Sala 2: b, Sala 3: c, Sala 4: d, Sala 5: e");
            Sala = Convert.ToChar(Console.ReadLine());

            switch (Sala)
            {
                case 'a':
                    Console.WriteLine(1 < edad && edad <= 5 ? "Elige un juego: Juego 1:1 o juego 5:5" : "No puedes estar aqui");
                    juego = Convert.ToChar(Console.ReadLine());
                    switch (juego)
                    {
                        case '1':
                            valor = 3000;
                            Console.WriteLine($"En ese caso en sala 1, jugando al juego 1, tu edad es :{edad} y estas pagando: {valor}"); break;
                        case '5':
                            valor = 7000;
                            Console.WriteLine($"En ese caso en sala 1, jugando al juego 5, tu edad es :{edad} y estas pagando: {valor}"); break;
                        default:
                            Console.WriteLine("Esa no es una opción");
                            break;
                    }
                   break;
                case 'b':
                    Console.WriteLine(6 < edad && edad <= 16 ? "Elige un juego: juego 3:3 o juego6:6" : "No puedes estar aqui");
                    juego = Convert.ToChar(Console.ReadLine());
                    switch (juego)
                    {
                        case '3':
                            valor = 7000;
                            Console.WriteLine($"En ese caso en sala 2, jugando al juego 3, tu edad es :{edad} y estas pagando: {valor}"); break;
                        case '6':
                            valor = 9000;
                            Console.WriteLine($"En ese caso en sala 2, jugando al juego 6, tu edad es :{edad} y estas pagando: {valor}"); break;
                        default:
                            Console.WriteLine("Esa no es una opción");
                            break;
                    }
                    break;
                case 'c':
                    Console.WriteLine(17< edad && edad <= 25? "Elige un juego: juego 2:2 o juego7:7" : "No puedes estar aqui");
                    juego = Convert.ToChar(Console.ReadLine());
                    switch (juego)
                    {
                        case '2':
                            valor = 5000;
                            Console.WriteLine($"En ese caso en sala 3, jugando al juego 2, tu edad es :{edad} y estas pagando: {valor}"); break;
                        case '7':
                            valor = 10000;
                            Console.WriteLine($"En ese caso en sala 3, jugando al juego 7, tu edad es :{edad} y estas pagando: {valor}"); break;
                        default:
                            Console.WriteLine("Esa no es una opción");
                            break;
                    }
                    break;
                case 'd':
                    Console.WriteLine(6 < edad && edad <= 16 ? "Elige un juego: juego 4:4 o juego8:8" : "No puedes estar aqui");
                    juego = Convert.ToChar(Console.ReadLine());
                    switch (juego)
                    {
                        case '4':
                            valor = 9000;
                            Console.WriteLine($"En ese caso en sala 4, jugando al juego 4, tu edad es :{edad} y estas pagando: {valor}"); break;
                        case '8':
                            valor = 7000;
                            Console.WriteLine($"En ese caso en sala 4, jugando al juego 8, tu edad es :{edad} y estas pagando: {valor}"); break;
                        default:
                            Console.WriteLine("Esa no es una opción");
                            break;
                    }
                    break;
                case 'e':
                    Console.WriteLine(edad < 25 ? "Elige un juego: juego 9:9 o juego10:t" : "No puedes estar aqui");
                    juego = Convert.ToChar(Console.ReadLine());
                    switch (juego)
                    {
                        case '9':
                            valor = 5000;
                            Console.WriteLine($"En ese caso en sala 5, jugando al juego 9, tu edad es :{edad} y estas pagando: {valor}"); break;
                        case 't':
                            valor = 3000;
                            Console.WriteLine($"En ese caso en sala 5, jugando al juego 10;tu edad es :{edad} y estas pagando: {valor}"); break;
                        default:
                            Console.WriteLine("Esa no es una opción");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Esa no es una sala");
                    break;

            }
        }
    }
}

