using System;

namespace FinalSoru2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Seri Hesabı programı

            Console.Write("Seri hesabını yapmak istediğiniz sayıyı giriniz:");
            int x = int.Parse(Console.ReadLine());

            int toplam = 0;

            for (int i = 0; i <= x; i++)
            {
                toplam = toplam + (i * i);
            }
            Console.WriteLine("Seri Hesabımızın sonucu:"+toplam);
        }
    }
}
