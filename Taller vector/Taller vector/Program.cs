namespace Taller_vector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Num=new int[15];
            int numayor = 0;
            int numenor = 99999;
            for (int i = 0 ; i < Num.Length; i++)
            {
                Console.WriteLine("Ingrese un número");
                Num[i] = Convert.ToInt32(Console.ReadLine());
               
                if (Num[i] > numayor)
                {
                    numayor = Num[i];
                }
                if (Num[i] < numenor )
                {
                    numenor = Num[i];
                }
            }
            Console.WriteLine($"Mayor={numayor} menor={numenor}");

        }
    }
}
