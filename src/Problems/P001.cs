using System;

namespace ProjectEuler.Problems
{
    public class P001
    {
        public P001()
        {    
        }

        public static int NaturalNumbers (int max)
        {
            var sumOf3 = 0;
            var sumOf5 = 0;
            for (var i = 0 ; i < max; i++) {
                if (i % 3 == 0 || i % 5 == 0){
                    sumOf3 += i;
                }
            }

            return sumOf3 + sumOf5;
        }
    }
}
