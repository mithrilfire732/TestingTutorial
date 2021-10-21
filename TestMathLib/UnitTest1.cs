using System;
using Xunit;


namespace TestMathLib
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(3,1,2)]
        public void TestAdd(int ans, int a, int b)
        {
            Assert.Equal(ans, MathLibrary.MathLib.Add(a, b));
        }
        
        [Theory]
        [InlineData(1,3,2)]
        [InlineData(-1, 2, 3)]
        [InlineData(1, 5, 4)]
        [InlineData(0, 1, 1)]
        [InlineData(3, 3, 0)]

        public void TestSub(int ans, int a, int b)
        {
            Assert.Equal(ans, MathLibrary.MathLib.Sub(a, b));
        }
        [Fact]
        public void TestPi()
        {
            Assert.Equal(3.1415926m, MathLibrary.MathLib.Pi);
        }
    }
}
