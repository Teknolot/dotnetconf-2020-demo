using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace _03_Records
{
    public class Program
    {

        
        public record Ogrenci
        {
            public string Ad { get; set; }
            public string Soyad { get; set; }
        }

        public record Ogrenci2(int Yas)
        {
            public string Ad { get; set; }
            public string Soyad { get; set; }
        }

        public record Ogrenci3(string Ad, string Soyad);


        public class Ogrenci4
        {
            public string Ad { get; set; }
            public string Soyad { get; set; }

            public void Deconstruct(out string soyad, out string ad)
            {
                soyad = this.Soyad;
                ad = this.Ad;
            }
        }
        static void Main(string[] args)
        {
            var e = new Ogrenci4 { Ad = "Cihan", Soyad = "Yakar" };
            var (soyad, ad) = e;


            Console.WriteLine(soyad);

        }



    }
}

namespace Arkaplan
{
    public class Ogrenci3 : IEquatable<Ogrenci3>
    {
        protected virtual Type EqualityContract
        {
            //[System.Runtime.CompilerServices.NullableContext(1)]
            [CompilerGenerated]
            get
            {
                return typeof(Ogrenci3);
            }
        }

        public string Ad
        {
            get;
            init;
        }

        public string Soyad
        {
            get;
            init;
        }

        public Ogrenci3(string Ad, string Soyad)
        {
            this.Ad = Ad;
            this.Soyad = Soyad;
            //base..ctor();
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Ogrenci3");
            stringBuilder.Append(" { ");
            if (PrintMembers(stringBuilder))
            {
                stringBuilder.Append(" ");
            }
            stringBuilder.Append("}");
            return stringBuilder.ToString();
        }

        protected virtual bool PrintMembers(StringBuilder builder)
        {
            builder.Append("Ad");
            builder.Append(" = ");
            builder.Append((object?)Ad);
            builder.Append(", ");
            builder.Append("Soyad");
            builder.Append(" = ");
            builder.Append((object?)Soyad);
            return true;
        }

        //[System.Runtime.CompilerServices.NullableContext(2)]
        public static bool operator !=(Ogrenci3? r1, Ogrenci3? r2)
        {
            return !(r1 == r2);
        }

        //[System.Runtime.CompilerServices.NullableContext(2)]
        public static bool operator ==(Ogrenci3? r1, Ogrenci3? r2)
        {
            return (object)r1 == r2 || (r1?.Equals(r2) ?? false);
        }

        public override int GetHashCode()
        {
            return (EqualityComparer<Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Ad)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Soyad);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as Ogrenci3);
        }

        public virtual bool Equals(Ogrenci3? other)
        {
            return (object)other != null && EqualityContract == other!.EqualityContract && EqualityComparer<string>.Default.Equals(Ad, other!.Ad) && EqualityComparer<string>.Default.Equals(Soyad, other!.Soyad);
        }

        //	public virtual Ogrenci3<Clone>$()
        //{
        //	return new Ogrenci3(this);
        //}

        protected Ogrenci3(Ogrenci3 original)
        {
            Ad = original.Ad;
            Soyad = original.Soyad;
        }

        public void Deconstruct(out string Ad, out string Soyad)
        {
            Ad = this.Ad;
            Soyad = this.Soyad;
        }
    }
}
