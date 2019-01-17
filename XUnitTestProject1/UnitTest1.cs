using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.InRange(10, 5, 100);
        }

        [Fact]
        public void Test2()
        {
            Assert.True(1==1);
        }
    }
}
