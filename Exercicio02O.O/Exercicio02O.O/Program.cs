using System;
using System.Globalization;
namespace Exercicio02O.O
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario F = new Funcionario();

            Console.Write("Nome: ");
            F.Nome = Console.ReadLine();
            Console.Write("Sálario Bruto: ");
            F.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            F.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine();
            Console.WriteLine("Funcionario: " + F);


            Console.WriteLine();

            Console.Write("Digite a porcentagem para aumentar o sálario: ");
            double I = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            F.AumentaSalario(I);

            Console.WriteLine();

            Console.WriteLine("Dados atualizados: " + F);


        }
    }
}
