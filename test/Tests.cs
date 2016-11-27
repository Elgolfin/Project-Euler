using System;
using Xunit;
using ProjectEuler.Problems;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace TaxCalculator.Tests
{
    public class ProductTests
    {
        [Fact]
        public void Test_Should_Return_Hiya_Foo() 
        {
            var p = new P001();
            Assert.Equal("Hiya Foo!", P001.Test());
        }

        
        
    }
}
