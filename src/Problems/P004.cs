using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler.Problems
{
    public class P004
    {
        public P004()
        {    
            

        }

        public static int ReturnLargestPalindrome (int numOfDigits = 2) {
            var maxNumber = 0;
            var minNumber = 0;
            Int32.TryParse("".PadLeft(numOfDigits, '9'), out maxNumber);
            Int32.TryParse("1".PadLeft(numOfDigits - 1, '0'), out minNumber);
            var currentNumber = maxNumber;
            var largestPalindrome = 0;
            while (currentNumber >=1 ) {
                for (var i = currentNumber ; i >= minNumber ; i--) {
                    var testPalindrome = currentNumber * i;
                    if (testPalindrome > largestPalindrome && testPalindrome.ToString().Reverse() == testPalindrome.ToString()) {
                        largestPalindrome = Math.Max(largestPalindrome, testPalindrome);
                    }
                }
                currentNumber--;
            }
            return largestPalindrome;
        }

    }


    public static class StringExtensions {

        public static string Reverse (this string text)
        {
            if (text == null) { return String.Empty; }
            char[] array = text.ToCharArray();
            Array.Reverse(array);
            return (new string(array));
        }

    }
}
