using System;
namespace _2LB___3ZDN
{
    class Laba2_3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A=");
            long first = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("B=");
            long last = Convert.ToInt64(Console.ReadLine());
            long counter = 0;
            if (first % 2 == 1) first++;
            for (long i = first; i <= last; i += 2)
                for (long j = i; j % 2 == 0; j /= 2, counter++) ;
            Console.WriteLine("Maks=" + counter);
            Console.ReadLine();
        }
    }
}
