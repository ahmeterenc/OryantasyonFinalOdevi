using System;

namespace FinalSoru5
{
    class Program
    {
        //İki sayının çarpımının toplama işlemiyle gösterilmesi
        static void Main(string[] args)
        {
            Console.Write("1. sayıyı giriniz:");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.Write("2. sayıyı giriniz:");
            int sayi2 = int.Parse(Console.ReadLine());
            int carpim=0;

            if (sayi1>0 || sayi2>0)
            {
                for (int i = 0; i < sayi2; i++)
                {
                    carpim = carpim + sayi1;
                }


            }
            else
            {
                Console.WriteLine("Sayılarımız negatif olamaz.");
            }

            Console.WriteLine("Sayılarımızın toplama işlemi yaparak çarpımı:"+carpim);

        }
    }
}
