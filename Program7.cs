using System;

namespace FinalSoru7
{
    class Program
    {
        //Verilen saate eklenen dakika sonra saat kaç olur?

        static void Main(string[] args)
        {
            Console.Write("Dakika değeri giriniz:");
            int sayi = int.Parse(Console.ReadLine());

            if (sayi<500 || sayi>100)
            {
                int saat = sayi / 60;
                int dakika = sayi % 60;

                saat = saat + 8;
                dakika = dakika + 30;

                if (dakika>=60)
                {
                    saat = saat + (dakika / 60);
                    dakika = dakika % 60;

                    if (dakika==0)
                    {
                        Console.WriteLine("Dakika değerinden sonraki saatimiz:{0}:{1}0", saat, dakika);
                    }
                  
                }
                else
                {
                    Console.WriteLine("Dakika değerinden sonraki saatimiz:{0}:{1}", saat, dakika);
                }

                


            }
            else
            {
                Console.WriteLine("Lütfen belirtilen koşullara uygun giriş yapınız.");
            }

        }
    }
}
