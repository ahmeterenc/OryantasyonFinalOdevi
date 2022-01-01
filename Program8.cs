using System;
using System.Linq;

namespace FinalSoru8
{
    class Program
    {
        //İkinci dereceden denklem için kök değerlerini bulan program
        static void Main(string[] args)
        {
            Console.WriteLine("ax^2+bx+c=0 için a,b ve c değerlerini girin:");
            Console.Write("a Değeri:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b Değeri:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c Değeri:");
            double c = Convert.ToDouble(Console.ReadLine());

            double d = b * b - 4 * a * c;

            if (d > 0)
            {
                Console.WriteLine("Denklemin iki kökü vardır.");
                double x1 = ((-b - Math.Sqrt(d)) / 2 * a);
                double x2 = ((-b + Math.Sqrt(d)) / 2 * a);
                Console.WriteLine("x1 = {0}, x2 = {1}", x1, x2);

            }
            else if (d == 0)
            {
                Console.WriteLine("Denklemin bir kökü vardır.");
                double x = -b / (2 * a);
                Console.WriteLine("x = " + x);
            }
            else
            {
                Console.WriteLine("Denklemin kökü sanaldır.");



            }


        }
    }
}
