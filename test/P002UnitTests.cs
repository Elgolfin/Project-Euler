using System;
using Xunit;
using ProjectEuler.Problems;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace ProjectEulerUnitTests
{
    public class P002UnitTests
    {
        [Fact]
        public void The_Sum_Of_Even_Values_Under_100_Should_Return_44() 
        {
            Assert.Equal(44, P002.SumOfEvenValuesFibonacci(100));
        }
        
        [Fact]
        public void The_Sum_Of_Even_Values_Under_4000000_Should_Return_4613732() 
        {
            Assert.Equal(4613732, P002.SumOfEvenValuesFibonacci(4000000));
        }
        
    }
}
