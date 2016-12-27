using System;
using Xunit;
using ProjectEuler.Problems;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace ProjectEulerUnitTests
{
    public class P004UnitTests
    {
        [Fact]
        public void Multiply_91_Times_99_Should_Return_A_Palindrome() 
        {
            var result = 91*99;
            Assert.Equal(result.ToString(), result.ToString().Reverse());
        }

        [Theory]
        [InlineData(2, 9009)]
        [InlineData(3, 906609)]
        public void Multiply_91_Times_99_Should_Return_A_Palindrome(int numOfDigits, int largestPalindromeExpected) 
        {
            Assert.Equal(largestPalindromeExpected, P004.ReturnLargestPalindrome(numOfDigits));
        }
        
    }
}
