using System;
using System.Globalization;

namespace Saida_de_Dados
{
    class Program
    {
        static void Main(string[] args)
        {
            /*PRIMEIRA PARTE DA AULA*/

            //char genero = 'F';
            //int idade = 32;
            //double saldo = 10.35784;
            //string nome = "Maria";

            //Console.Write("Bom dia!");
            //Console.WriteLine("Boa tarde!");
            //Console.WriteLine("Boa noite!");
            //Console.WriteLine("------");
            //Console.WriteLine(genero);
            //Console.WriteLine(idade);
            //Console.WriteLine(saldo);
            //Console.WriteLine(nome);
            //Console.WriteLine(saldo.ToString("F2"));//imprime com 2 casas decimais
            //Console.WriteLine(saldo.ToString("F4"));//imprime com 4 casas decimais
            //Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));//imprime com 4 casas decimais trocando a , por .

            /*SEGUNDA PARTE DA AULA*/
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";

            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais.",nome,idade,saldo);   //Place Holder. (:Fnumero) delimita o número de casas decimais

            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais;");         //Interpolação

            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais.");     //Concatenação
        }
    }
}
