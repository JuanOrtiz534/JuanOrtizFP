namespace Taller_condicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int mayor = 0;
            int medio = 0;
            int menor = 0;

            Console.WriteLine("Ingrese el número 1:");
            num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número 2:");
            num2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número 3:");
            num3 = Int32.Parse(Console.ReadLine());
            if (num1 == num2 && num1 == num3)
            {
                Console.WriteLine("No numeros iguales");
            }
            if (num1 != num2 && num1 != num3)
            { 
            mayor = num1 > num2
                ? (num1 > num3 ? num1 : num3) : (num2 > num3 ? num2 : num3);
            menor = num1 < num2
                ? (num1 < num3 ? num1 : num3) : (num2 < num3 ? num2 : num3);
            medio = num1 < num2 && num2 < num3
                ? (num1 > num3 ? num1 : num2) : (num2 < num1 ? num2 : num3);
            
                Console.WriteLine($"Mayor:{mayor}, medio:{medio} y menor: {menor} ");
            }

        
        }
    }
}
