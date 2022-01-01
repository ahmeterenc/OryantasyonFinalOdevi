using System;

namespace FinalSoru10
{
    class Program
    {
        //Girilen notların ortalamasını hesaplayan program
        static void Main(string[] args)
        {
            int toplam = 0;

            Console.Write("Kac adet notun girileceğini yazınız:");

            string gelenSayi = Console.ReadLine();
            Console.WriteLine(gelenSayi + " adet notun ortalaması hesaplanacak.");
            int donussayisi = Convert.ToInt32(gelenSayi);

            for (int i = 1; i <= donussayisi; i++)
            {
                Console.Write(i + ". not =");
                int sayi = Convert.ToInt32(Console.ReadLine());
                toplam = toplam + sayi;
            }
            double ort = (double)toplam / donussayisi;
            Console.WriteLine("Girilen Notun Ortalaması= " + ort);
            
        }
    }
}
