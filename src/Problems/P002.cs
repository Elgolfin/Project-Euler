using System;

namespace ProjectEuler.Problems
{
    public class P002
    {
        public P002()
        {    
        }

        public static int SumOfEvenValuesFibonacci (int max)
        {
            var previous = 1;
            var current = 2;
            var sum = 2;
            var next = previous + current;
            while (next < max) {
                if (next % 2 == 0) {
                    sum += next;
                }
                previous = current;
                current = next;
                next = previous + current;
            }

            return sum;
        }
    }
}
