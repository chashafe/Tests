using System;
using Xunit;

namespace ConsoleApp.Tests
{
    public class SomethingShould
    {

        [Fact]
        public void ThrowsAnExcpetion_IfDividingByZero()
        {
            var x = 1;
            var y = 0;
            var sut = new Something();

            Assert.Throws<DivideByZeroException>(()=>sut.DivideNumbers(x,y));
        }

    }
}
