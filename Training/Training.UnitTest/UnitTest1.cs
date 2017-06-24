using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Training.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            var myArray = new int[]{ 0, 1, 2, 3, 4, 5 };

            //Act
            var result = Maths.Instance.Maximum(myArray);

            //Assert
            Assert.AreEqual(result, 5);
        }
    }
}
