using System.Runtime.InteropServices;

namespace _2.Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OPERADORES
            //Operadores Numéricos
            // Cambio de signo

            int nume1 = 5;
            int nume2 = -nume1;
            int nume3 = +nume2;
            int nume4 = -nume3;

            Console.WriteLine($"{nume1} // {nume2} // {nume3} // {nume4}");

            //Operadores aritméticos

            float nume5= 3 + 5;//suma
            float nume6 = 100 - 26;//Resta
            float nume7 = 4 * 2;//Multiplicación
            //float nume8=(float) 5/3;//divición
            float nume8 = 5f / 3f;
            double nume9 = 5d / 3;
            decimal nume10 = 5 / 3m;

            Console.WriteLine($"suma: {nume5}, resta: {nume6}, multi: {nume7}, división: {nume8}, nume 9: {nume9}, nume 10: {nume10}");

            //Operadores incremento(++), decremento(--)
            nume1++;//nume1 = nume1 + 1; Incremento
            nume2--;//nume2 = nume 2 - 1;Decremento
            nume4 -= 20; //nume4= nume4 -20;
            nume5 *= 31;// nume5 = nume5 * 31;
            nume7 /= nume1; //nume7 = nume7 / nume1;

            //Orden de evaluación operadores aritméticos
            int nume11 = 4 * 3 / 2;// *,/(orden de ejecución)
            int nume12 = 4 / 3 * 2;// /,*
            int nume13 = (4 * 3) / 2;// (),/
            int nume14 = 4 * (3 / 2);// (),*
            int nume15 = 4 + 6 * 3;//*,+
            int nume16 = 4 + 6 * (2 - 1) / 2;// (), * , / ,*
            Console.WriteLine($"nume11:{nume11}, nume12:{nume12}, nume13:{nume13}, nume14:{nume14}, nume15:{nume15}, nume16:{nume16}");

            //Operadores lógicos
            //Conjunción - AND - &&
            Console.WriteLine("TABLA DE VERDAD CONJUNCIÓN");
            Console.WriteLine($"V && V = {true && true}");
            Console.WriteLine($"V && F = {true && false}");
            Console.WriteLine($"F && V = {false && true}");
            Console.WriteLine($"F && F = {false && false}");

            //Disyunción - OR - ||
            Console.WriteLine("TABLA DE VERDAD CONJUNCIÓN");
            Console.WriteLine($"V || V = {true || true}");
            Console.WriteLine($"V || F = {true || false}");
            Console.WriteLine($"F || V = {false || true}");
            Console.WriteLine($"F || F = {false || false}");
            bool exp1 = true;
            bool exp2 = false;  
            bool exp3= exp1 && exp2;
            bool exp4 = exp1 || exp3;
            bool exp5 =!exp4 || exp2;

            Console.WriteLine($"exp1 : {exp1}, exp2 : {exp2}, exp3 : {exp3}, exp4:{exp4}, exp5 : {exp5}");
        }
    }
}
