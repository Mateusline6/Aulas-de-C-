﻿using System;
using System.Globalization;

namespace ExercicioDeR
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();
          
            Console.WriteLine("Entre com as medidas do triangulo x: ");

            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triangulo y: ");

            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double p = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));


            p = (y.A + y.B + y.C) / 2;

            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));


            Console.WriteLine("Area de x = " + areaX.ToString("F4"), CultureInfo.InvariantCulture);
            Console.WriteLine("Area de y = " + areaY.ToString("F4"), CultureInfo.InvariantCulture);


            if(areaX > areaY)
            {
                Console.WriteLine("Maior area: X");

            }
            else
            {
                Console.WriteLine("Maior area: Y");

            }


        }
    }
}
