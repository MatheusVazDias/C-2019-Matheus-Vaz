using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            bool completo = false;
            char genero = 'F';
            char letra = '\u0041';

            sbyte   n1 = 126;
            int     n2 = 1000;
            int     n3 = 2147483647;
            long    n4 = 2147483648L;
            float   n5 = 4.5f;
            double  n6 = 4.5;

            string nome = "Matheus Vaz";

            object obj = "Nome de pessoa";
            object obj2 = 4.5f;

            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);

            Console.WriteLine("\n"+nome);

            Console.WriteLine(obj);
            Console.WriteLine(obj2);

            int min1 = int.MinValue;
            int max1 = int.MaxValue;
            Console.WriteLine("\n" + min1);
            Console.WriteLine(max1);

            sbyte smin = sbyte.MinValue;
            sbyte smax = sbyte.MaxValue;
            Console.WriteLine("\n" + smin);
            Console.WriteLine(smax);

            decimal dcm = decimal.MaxValue;
            Console.WriteLine("\n" + dcm);
        }
    }
}
