namespace _1.InicioVisualStudio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Esta es la declaración e inicialización de una variable
            string nombre = "Juan";
            const string iva = "19%";


            Console.Write("Hola," + nombre + "\n");
            Console.Write("\tBiembenido a la clase de programación.");
            nombre = "Pablo";
            Console.Write("\n" + nombre);
            //iva="20%"; No se puede cambiar el valor de una constante

            //Tipos de datos
            byte dato1 = 23;
            int dato2 = 4324242;
            long dato3 = 42424424234;
            double dato4 = 326.625;
            char dato5 = 'A'; //maximo de um solo caracter
            bool dato6 = false; //Almacena true o false
            object dato7 = new Program();
        }
    }
}
