using System;
using System.Runtime.CompilerServices;

namespace _08_ModuleInitializers
{
    public static class Modul
    {
        [ModuleInitializer]
        public static void Hazirla()
        {
            Degiskenler.Selam = "Merhabalar";
        }
    }

    class Degiskenler
    {
        public static string Selam;
    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Degiskenler.Selam);
        }

    }


}
