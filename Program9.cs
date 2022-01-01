using System;

namespace FinalSoru9
{
    class Program
    {
        //Ürünün kdvli fiyatını hesaplayan program
        static void Main(string[] args)
        {
            float fiyat, kdv, tutar, yuzde;
            Console.Write("Fiyatı Giriniz:");
            fiyat = Convert.ToSingle(Console.ReadLine());
            Console.Write("KDV yüzdesini Giriniz:");
            yuzde = Convert.ToSingle(Console.ReadLine());
            
            kdv = fiyat * yuzde /100;
            tutar = fiyat + kdv;
            
            Console.WriteLine("Kdv = {0}tl ----- Tutar = {1}tl", kdv, tutar);
            
        }
    }
}
