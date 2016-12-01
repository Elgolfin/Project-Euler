using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler.Problems
{
    public class P003
    {
        /// See http://www.counton.org/explorer/primes/checking-if-a-number-is-prime/
        public P003()
        {    
            

        }

        public static IEnumerable<double> GetPrimeFactors (double number) {
            
            var maxPrimeNumberToTest = Math.Floor(Math.Sqrt(number));
            
            var primeFactors = new List<double>();
            var primeNumbers = GetPrimeNumbers(maxPrimeNumberToTest).ToList(); 
            var index = 0;
            var numberToTest = number;

            while (numberToTest > 1 ){
                if (numberToTest % primeNumbers[index] == 0) {
                    numberToTest = numberToTest / primeNumbers[index];
                    primeFactors.Add(primeNumbers[index]);
                }
                else {
                    index++;
                }
            }
            return primeFactors;
        }

        public static IEnumerable<double> GetPrimeNumbers (double max)
        {
            var current = 2;
            var primeNumbers = new List<double>(); 
            primeNumbers.Add(current);
            var isPrimeNumber = true;
            while (++current <= max) {
                foreach (var prime in primeNumbers) {
                    // current is not a prime number, test the following number
                    if (current % prime == 0) {
                        isPrimeNumber = false;
                        break;
                    }
                }
                if (isPrimeNumber) {
                    primeNumbers.Add(current);
                }
                isPrimeNumber = true;
            }
            return primeNumbers;
        }
    }
}
