using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Örnek liste
        var numaralar = new List<string> { "LAB-001", "LAB-002", "LAB-003" };
        var bosListe = new List<string>();

        // Konsoldan test etmek için
        Console.Write("Aranacak numarayı girin: ");
        string? aranan = Console.ReadLine();

        if (!string.IsNullOrEmpty(aranan))
        {
            bool sonuc = NumaraVarMi(numaralar, aranan);
            Console.WriteLine(sonuc ? "Bulundu" : "Bulunamadı");
        }
    }

    // Uygulama 2: Contains kullanmadan foreach ile arama
    static bool NumaraVarMi(List<string> liste, string aranan)
    {
        foreach (string numara in liste)
        {
            if (numara == aranan)
                return true;
        }

        return false; // Eşleşme çıkmazsa en son false döner
    }
}