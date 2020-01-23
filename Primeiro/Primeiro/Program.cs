using System;
using System.Globalization;
namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            bool completo = false;
            char genero = 'F';
            char letra = '\u0041'; // usando codigo unitario
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L;
            float n5 = 4.5f;
            double n6 = 4.5;
            string nome = "Mateus Efigenio";
            double saldo = 10.354;
            int idade = 24;

            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture)); // printando o valor decimal com ponto e nao virgula

            //Imprimindo e Utilizando Placeholder
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);

            // utilizando a interpolação
            Console.WriteLine($"{nome} tem {idade} e tem saldo igual a {saldo:F2} reais");

            Console.WriteLine(nome+ "tem "+idade+" e tem saldo igual a "+saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais" );

        }
    }
}
