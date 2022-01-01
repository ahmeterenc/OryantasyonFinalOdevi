using System;

namespace FinalSoru4
{
    class Program
    {
        //Dogum tarihi girilen kişinin yaşını hesaplamak
        static void Main(string[] args)
        {
            Console.Write("Doğum tarihinizi girin:");
            DateTime dogum = Convert.ToDateTime(Console.ReadLine());

            TimeSpan sonuc = DateTime.Now - dogum;

            Console.Write("Yaşınız:");
            Console.Write(sonuc.Days/365);
        }
    }
}
