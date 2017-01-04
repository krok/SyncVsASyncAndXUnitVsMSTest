using System;
using System.Linq;
using Xunit;

namespace XUnitWithMSAsserts
{
    public class UnitTest1
    {
        [Fact]
        public void TestMethod1()
        {
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(1, 2, " 1 does not equal 2");
        }
    }
}
