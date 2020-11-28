using System;

namespace _02_InitOnlyProperties
{
    public class Program
    {
        public static void Main()
        {
            var ogrenci1 = new Ogrenci { Ad = "Cihan", Soyad = "Yakar" };
            
            
            Ogrenci ogrenci2 = new() { Ad = "Daron", Soyad = "Yondem" };

          //   // Ogrenci ogrenci3 = ogrenci2 with { Ad = "İlkay" };

            Console.WriteLine($"{ogrenci1.Ad} {ogrenci2.Ad}");
        }
    }

    public sealed class Ogrenci
    {
        
        public string Ad { get; init; }
        public string Soyad { get; init; }
    }
}