using System;

namespace _04_PatternMatchingNews
{
    class Program
    {

        public record Ogrenci
        {
            public string Ad { get; set; }
            public string Soyad { get; set; }
        }

        static void Main(string[] args)
        {

            var a = "kedi";

            if(a is null or "kedi")
            {

            }
            var b = new Ogrenci { Ad = "Cihan", Soyad = "Yakar" };

            if (b is not null and {Soyad:"Yakar"})
            {

            }


            //if (a != null && !(a == "kedi"))
            //{
            //}
            //if ((object)b != null && b.Soyad == "Yakar")
            //{
            //   
            //}
            Console.WriteLine("Hello World!");
        }
    }
}
