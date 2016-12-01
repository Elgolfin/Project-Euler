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
            var primeFactors = P003.GetPrimeFactors(600851475143).ToList();
            Console.Write(primeFactors[primeFactors.Count - 1]);
        }
    }
}
