using System;
using System.Collections;

public class AsalSayiListesi
{
    public static void Main(string[] args)
    {
        ArrayList asalSayilar = new ArrayList();
        ArrayList asalOlmayanSayilar = new ArrayList();
        int sayac = 0;

        while (sayac < 20)
        {
            Console.Write("Pozitif bir sayı girin: ");
            string giris = Console.ReadLine();

            if (int.TryParse(giris, out int sayi) && sayi > 0)
            {
                if (AsalMi(sayi))
                {
                    asalSayilar.Add(sayi);
                }
                else
                {
                    asalOlmayanSayilar.Add(sayi);
                }
                sayac++;
            }
            else
            {
                Console.WriteLine("Geçersiz giriş! Pozitif bir sayı girin.");
            }
        }

        asalSayilar.Sort();
        asalSayilar.Reverse();

        asalOlmayanSayilar.Sort();
        asalOlmayanSayilar.Reverse();

        Console.WriteLine("\nAsal Sayılar (Büyükten Küçüğe):");
        foreach (int sayi in asalSayilar)
        {
            Console.Write(sayi + " ");
        }

        Console.WriteLine("\n\nAsal Olmayan Sayılar (Büyükten Küçüğe):");
        foreach (int sayi in asalOlmayanSayilar)
        {
            Console.Write(sayi + " ");
        }

        Console.WriteLine("\n\nAsal Sayılar Dizisi:");
        Console.WriteLine("Eleman Sayısı: " + asalSayilar.Count);
        Console.WriteLine("Ortalama: " + OrtalamaHesapla(asalSayilar));

        Console.WriteLine("\nAsal Olmayan Sayılar Dizisi:");
        Console.WriteLine("Eleman Sayısı: " + asalOlmayanSayilar.Count);
        Console.WriteLine("Ortalama: " + OrtalamaHesapla(asalOlmayanSayilar));
    }

    public static bool AsalMi(int sayi)
    {
        if (sayi <= 1)
            return false;

        for (int i = 2; i <= Math.Sqrt(sayi); i++)
        {
            if (sayi % i == 0)
                return false;
        }
        return true;
    }

    public static double OrtalamaHesapla(ArrayList liste)
    {
        if (liste.Count == 0)
            return 0;

        double toplam = 0;
        foreach (int sayi in liste)
        {
            toplam += sayi;
        }
        return toplam / liste.Count;
    }
}
