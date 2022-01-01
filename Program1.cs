using System;

namespace FinalSoru1

{
    class Program1
    {
        //Vücut kitle endeksi programı

        static void Main(string[] args)
        {
            Console.Write("Boyunuzu cm olarak giriniz:");
            double length = int.Parse(Console.ReadLine());

            Console.Write("Kilonuzu kg olarak giriniz:");
            double weight = int.Parse(Console.ReadLine());


           double index = length / weight;

            if (index>2.5)
            {
                Console.WriteLine("İndex değeriniz zayıf.");
            }
            else if (2<=index && index<=2.5)
            {
                Console.WriteLine("İndex değeriniz normal.");
            }
            else if(index<2) 
            {
                Console.WriteLine("İndex değeriniz kilolu");
            }
            else
            {
                Console.WriteLine("İndex değeriniz kriterlerden herhangi birini sağlamıyor.");
            }
        }
    }
}
