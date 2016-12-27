using System;
using ProjectEuler.Problems;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var largestPalindrome = P004.ReturnLargestPalindrome(3);
            Console.WriteLine($"The largest palindrome made from the product of two 3-digit number is {largestPalindrome}");
        }
    }
}
