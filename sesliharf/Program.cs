using System;
using System.Collections.Generic;  // List için gerekli namespace

class Program
{
    static void Main()
    {
        Console.Write("Bir cümle giriniz: ");
        string cumle = Console.ReadLine().ToLower(); // Küçük harfe çevirerek işlem yap

        char[] sesliHarfler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
        
        List<char> bulunanSesliler = new List<char>();

        foreach (char harf in cumle)
        {
            if (Array.Exists(sesliHarfler, s => s == harf)) 
            {
                bulunanSesliler.Add(harf);  // Harfi listeye ekle
            }
        }

        bulunanSesliler.Sort();  // List'i sıralama

        Console.WriteLine("\nCümlede geçen sesli harfler (alfabetik sıralı): " + string.Join(", ", bulunanSesliler));
    }
}
