using System;

namespace FinalSoru6
{
    class Program
    {
        //Basamaklarındaki sayıların küpleri toplamını alan program 
        // Eşittir değeri için 371 alınabilir.

        static void Main(string[] args)
        {
            Console.Write("Sayıyı girin:");
            int sayi = int.Parse(Console.ReadLine());

            int basamaklar = sayi.ToString().Length;
            int toplam = 0;
            for (int i = 0; i < basamaklar; i++)
            {
                toplam += Convert.ToInt32(sayi.ToString().Substring(i, 1))* Convert.ToInt32(sayi.ToString().Substring(i, 1))* Convert.ToInt32(sayi.ToString().Substring(i, 1));
            }
            Console.WriteLine("Girilen {0} sayısının basamaklarının küpleri toplamı = {1}",sayi,toplam);

            if (toplam == sayi)
            {
                Console.WriteLine("Sayımızın basamaklarının küpleri toplamı kendine eşittir.");
            }
            else
            {
                Console.WriteLine("Sayımızın basamakları küpleri toplamı kendine eşit değildir.");
            }
        }
    }
}
