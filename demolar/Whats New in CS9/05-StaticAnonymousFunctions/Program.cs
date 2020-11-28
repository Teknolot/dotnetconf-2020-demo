using System;
using System.Linq;

namespace _05_StaticAnonymousFunctions
{
    class Program
    {

        
        static void Main(string[] args)
        {

            int[] a = { 1, 2, 3, 5, 9 };

            var b = a.Select(static (x) => x * 4);

            foreach (var x in b)
            {
                Console.WriteLine(b);
            }
            
        }

       
    }
}
