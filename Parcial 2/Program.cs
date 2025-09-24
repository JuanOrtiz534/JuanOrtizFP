using System.ComponentModel.Design;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Parcial_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int alumnos = 0;
            int nota = 0;
            int notastotal = 0;
            int promedio = 0;
            int contador = 0;
            int menor = 0;
            int mayor= 0;
            int aprovados= 0;
            int notaactu = 0;
            do
            {
                Console.WriteLine($"Ingrese nota del alumno {alumnos + 1}");
                nota = Convert.ToInt32(Console.ReadLine());
                notastotal = nota + notastotal;
                if (nota >= 6)
                {
                    aprovados++;
                }
               

                alumnos++;
                contador++;
            } while (contador <= 13);
            {
                Console.WriteLine($"Promedio general={notastotal / alumnos}, Nota mayor={mayor},nota menor ={menor} y aprovarón = {aprovados} ");
            }
        }
    }
}
