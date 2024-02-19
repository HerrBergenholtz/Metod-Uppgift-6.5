using System;

namespace Uppgift_6_5
{
    class Program
    {
        static void Main()
        {
            string test1 = "Hejsan";
            string test2 = "Hejsansvejsan";

            Console.WriteLine(Längst(test1, test2));

            int tal1 = 10;
            int tal2 = 20;

            Console.WriteLine(Längst(tal1, tal2));
        }

        static int Längst(int tal1, int tal2)
        {
            if (tal1 >= tal2) return tal1;
            else return tal2;
        }

        static string Längst(string sträng1, string sträng2)
        {
            if (sträng1.Length >= sträng2.Length) return sträng1;
            else return sträng2;
        }
    }
}