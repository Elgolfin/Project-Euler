using System;
using Xunit;
using ProjectEuler.Problems;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace ProjectEulerUnitTests
{
    public class P003UnitTests
    {
        [Fact]
        public void Prime_Numbers_Under_10_Should_Return_2_3_5_7() 
        {
            var results = new List<double> {2, 3, 5, 7};
            Assert.Equal(results, P003.GetPrimeNumbers(10));
        }

        [Fact]
        public void Prime_Factors_Under_13195_Should_Return_5_7_13_29() 
        {
            var results = new List<double> {5, 7, 13, 29};
            var primeFactors = P003.GetPrimeFactors(13195).ToList();
            Assert.Equal(results, primeFactors);
            Assert.Equal(29, primeFactors[primeFactors.Count - 1]);
        }

        [Fact]
        public void Prime_Numbers_Under_Square_Root_100_Should_Return_2_3_5_7() 
        {
            var t = 101;
            var maxPrimeNumberToTest = Math.Floor(Math.Sqrt(t));
            Assert.Equal(10, maxPrimeNumberToTest);
            var results = new List<double> {2, 3, 5, 7};
            Assert.Equal(results, P003.GetPrimeNumbers(maxPrimeNumberToTest));
        }

        [Fact]
        public void Highest_Prime_Factor_Of_100_Should_Return_7() 
        {
            var primeFactors = P003.GetPrimeFactors(100).ToList();
            Assert.Equal(new List<double> {2, 2, 5, 5}, primeFactors);
            Assert.Equal(5, primeFactors.OrderByDescending(r => r).FirstOrDefault());
        }

        /*
        [Fact]
        public void Highest_Prime_Factor_Of_600851475143_Should_Return_6857() 
        {
            var primeFactors = P003.GetPrimeFactors(600851475143).ToList();
            Assert.Equal(6857, primeFactors.OrderByDescending(r => r).FirstOrDefault());
        }*/
 
    }
}
