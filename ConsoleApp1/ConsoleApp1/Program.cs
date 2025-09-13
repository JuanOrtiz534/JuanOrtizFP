namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Hombres = 0;
            int Mujeres = 0;
            int Mayordeedad = 0;
            int Menordeedad = 0;
            int contador = 0;
            int edad=0;

            do
            {
                Console.WriteLine($"Alumno # {contador + 1}");
                Console.WriteLine("¿Cual es su genero?: H=Hombre o M=Mujer");
                string sexo = Console.ReadLine();
                Hombres += Convert.ToInt32(sexo == "H" || sexo == "h");
                Mujeres += Convert.ToInt32(sexo == "M" || sexo == "m");
                Console.WriteLine("¿Cual es tu edad?");
                edad = int.Parse(Console.ReadLine());
                if(edad >= 18)
                {
                    Mayordeedad++;
                }
                else
                {
                    Menordeedad++; 
                }
                contador++;
            } while (contador < 10);
            Console.WriteLine($"Hay: {Hombres} hombres, {Mujeres} mujeres, {Mayordeedad} Mayores de edad y {Menordeedad} menores de edad");
        }
    }
}
