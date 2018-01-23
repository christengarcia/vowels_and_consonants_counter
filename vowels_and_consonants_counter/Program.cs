/*
 * C# Program to Count number of Vowels and consonants from a given String
 */

using System;

namespace vowels_and_consonants_counter
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] sentence = new char[100];

            int i, vowels = 0, consonants = 0, special = 0, n;
            Console.WriteLine("Enter the Length of the sentence  \n");
            n = int.Parse(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                sentence[i] = Convert.ToChar(Console.Read());
            }
        }
    }
}
