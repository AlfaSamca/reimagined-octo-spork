using System;
namespace _2LB___2ZDN
{
    class Laba2_2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("String:");
            string InputString1 = Console.ReadLine();
            string[] Words = InputString1.Split(' ');
            for (int i = Words.Length - 1; i >= 0; i--)
            {
                Console.Write(Words[i] + " ");
            }
        }
    }
}
