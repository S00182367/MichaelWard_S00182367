using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MichaelWard_S00182367;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPrecent()
        {
            //Arrange
            Price pp1 = new Price();
            int total = 105;

            //Act
            pp1 * 5 / 100;
            //Assert
        }
    }
}
