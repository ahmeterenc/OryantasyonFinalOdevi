using System;

namespace FinalSoru3
{
    class FinalSoru
    {
        //Sayıların kareleri toplamı
        static void Main(string[] args)
        {
            Console.Write("Birinci sayıyı giriniz:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci sayıyı giriniz:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            int toplam = (sayi1 * sayi1) + (sayi2 * sayi2);

            Console.WriteLine("Sayılarımızın karelerinin toplamı :"+ toplam); 
        }
       
    }
}
