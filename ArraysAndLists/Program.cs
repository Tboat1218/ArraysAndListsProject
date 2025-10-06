using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an int array and populate it with numbers 1–10
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Create lists to hold evens and odds
            List<int> evens = new List<int>();
            List<int> odds = new List<int>();

            // Use foreach to separate numbers into evens and odds
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    evens.Add(num);
                }
                else
                {
                    odds.Add(num);
                }
            }

            // Display the even numbers using a foreach loop
            Console.WriteLine("Even numbers:");
            foreach (int even in evens)
            {
                Console.Write(even + " ");
            }

            // Display the odd numbers using a for loop
            Console.WriteLine("\nOdd numbers:");
            for (int i = 0; i < odds.Count; i++)
            {
                Console.Write(odds[i] + " ");
            }

            Console.WriteLine(); // Final line break
        }
    }
}

