using System;


namespace deneme2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayı Tahmin Oyununa Hoş Geldiniz");
            Console.WriteLine("Level Kaçtan Başlamak İstersiniz?");
            Console.WriteLine("1/2/3 ?");
            int level = int.Parse(Console.ReadLine());
            int hak;
            Random rnd = new Random();
            int sayi;
            int tahmin;
            int seviye;
            switch (level)
            {
                case 1:
                    sayi = rnd.Next(1, 10);
                    hak = 5;
                    seviye = 1;
                    Console.WriteLine("\n Seviye: " + seviye + "\n Verilen Hak: " + hak + "\n İyi Oyunlar");
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine("\n 1 Basamaklı Sayıyı Tahmin Ediniz");
                        tahmin = int.Parse(Console.ReadLine());
                        if (tahmin == sayi)
                        {
                            Console.WriteLine("Doğru Tahmin");
                            goto case 2;
                        }
                        else
                        {
                            hak = hak - 1;
                            Console.WriteLine("Yanlış tahmin Kalan Hakkınız: " + hak);
                        }
                    }
                    break;

                case 2:
                    sayi = rnd.Next(9, 100);
                    hak = 10;
                    seviye = 2;
                    Console.WriteLine("\n Seviye: " + seviye + "\n Verilen Hak: " + hak + "\n İyi Oyunlar");
                    for (int i = 0; i < 10; i++)
                    {
                        Console.WriteLine("\n 2 Basamaklı Sayıyı Tahmin Ediniz");
                        tahmin = int.Parse(Console.ReadLine());
                        if (tahmin == sayi)
                        {
                            Console.WriteLine("Doğru Tahmin");
                            goto case 3;
                        }
                        else
                        {
                            hak = hak - 1;
                            Console.WriteLine("Yanlış tahmin Kalan Hakkınız: " + hak);
                        }
                    }
                    break;

                case 3:
                    sayi = rnd.Next(99, 1000);
                    hak = 30;
                    seviye = 3;
                    Console.WriteLine("\n Seviye: " + seviye + "\n Verilen Hak: " + hak + "\n İyi Oyunlar");
                    for (int i = 0; i < 30; i++)
                    {
                        Console.WriteLine("\n 3 Basamaklı Sayıyı Tahmin Ediniz");
                        tahmin = int.Parse(Console.ReadLine());
                        if (tahmin == sayi)
                        {
                            Console.WriteLine("Tebrikler Kazandınız.");
                            break;
                        }
                        else
                        {
                            hak = hak - 1;
                            Console.WriteLine("Yanlış tahmin Kalan Hakkınız: " + hak);
                        }
                    }
                    break;
            }
        }
    }
}
