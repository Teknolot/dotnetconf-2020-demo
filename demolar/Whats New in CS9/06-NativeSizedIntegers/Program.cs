using System;

namespace _06_NativeSizedIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            nint a = 3;
            nuint b = 4;

            IntPtr ra= (IntPtr)3;
            UIntPtr rb = (UIntPtr)4;

            Console.WriteLine(a + (nint)b);
        }
    }
}
