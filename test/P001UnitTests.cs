using System;
using Xunit;
using ProjectEuler.Problems;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace ProjectEulerUnitTests
{
    public class P001UnitTests
    {
        [Fact]
        public void The_Sum_Of_Multiples_3_And_5_Under_10_Should_Return_23() 
        {
            Assert.Equal(23, P001.NaturalNumbers(10));
        }
        
        /// Do not count twice a multiple of 3 AND 5 at the same time
        [Fact]
        public void The_Sum_Of_Multiples_3_And_5_Under_16_Should_Return_60() 
        {
            Assert.Equal(60, P001.NaturalNumbers(16));
        }

        [Fact]
        public void The_Sum_Of_Multiples_3_And_5_Under_1000_Should_Return_233168() 
        {
            Assert.Equal(233168, P001.NaturalNumbers(1000));
        }
        
    }
}
