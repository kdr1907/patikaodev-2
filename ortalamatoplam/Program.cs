using System;

class Program
{
    static void Main()
    {
        int[] sayilar = new int[20];

        // Kullanıcıdan 20 sayı alma
        Console.WriteLine("Lütfen 20 adet sayı giriniz:");
        for (int i = 0; i < 20; i++)
        {
            Console.Write($"Sayı {i + 1}: ");
            while (!int.TryParse(Console.ReadLine(), out sayilar[i]))
            {
                Console.WriteLine("Geçersiz giriş! Lütfen bir tam sayı giriniz.");
                Console.Write($"Sayı {i + 1}: ");
            }
        }

        // Diziyi küçükten büyüğe sıralama
        Array.Sort(sayilar);

        // En küçük 3 sayı
        int[] enKucukler = { sayilar[0], sayilar[1], sayilar[2] };

        // En büyük 3 sayı (Ters sıralama yerine dizinin son elemanlarını alıyoruz)
        int[] enBuyukler = { sayilar[17], sayilar[18], sayilar[19] };

        // Ortalamaları hesaplama
        double ortalamaKucuk = OrtalamaHesapla(enKucukler);
        double ortalamaBuyuk = OrtalamaHesapla(enBuyukler);
        double toplamOrtalama = ortalamaKucuk + ortalamaBuyuk;

        // Sonuçları ekrana yazdırma
        Console.WriteLine("\nEn Küçük 3 Sayı: " + string.Join(", ", enKucukler));
        Console.WriteLine("En Büyük 3 Sayı: " + string.Join(", ", enBuyukler));

        Console.WriteLine($"\nEn Küçük 3 Sayının Ortalaması: {ortalamaKucuk:F2}");
        Console.WriteLine($"En Büyük 3 Sayının Ortalaması: {ortalamaBuyuk:F2}");
        Console.WriteLine($"Ortalama Toplamı: {toplamOrtalama:F2}");
    }

    // Ortalama hesaplayan metot
    static double OrtalamaHesapla(int[] dizi)
    {
        int toplam = 0;
        foreach (int sayi in dizi)
        {
            toplam += sayi;
        }
        return (double)toplam / dizi.Length;
    }
}

