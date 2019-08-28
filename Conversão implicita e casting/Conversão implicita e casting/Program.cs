using System;

namespace Conversão_implicita_e_casting
{
    class Program
    {
        static void Main(string[] args)
        {
            //conversão implícita
            float x = 4.5f;
            double y = x;

            Console.WriteLine(y);

            //conversão explicita
            double a;
            float b;

            a = 4.5;
            b = (float)a;

            Console.WriteLine(b);

            double c;
            int d;
            c = 4.5;
            d = (int)c;


            Console.WriteLine(d);

            int e = 5;
            int f = 2;

            double resultado = (double)e / f;
            Console.WriteLine(resultado);
        }
    }
}
