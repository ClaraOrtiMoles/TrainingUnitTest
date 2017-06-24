using System;
using Xunit;

namespace Training.UnitTest
{
    public class TrainingUnitTest
    {
        [Fact]
        public void MaximumMethod_MaxAtTheEnd_ReturnLastElement()
        {
            //Arrange
            var myArray = new int[]{ 0, 1, 2, 3, 4, 5 };

            //Act
            var result = Maths.Instance.Maximum(myArray);

            //Assert
            Assert.Equal(result, 5);
        }

        [Fact]
        public void MaximumMethod_OnlyOneElement_ReturntheOnlyElement()
        {
            //Arrange
            var myArray = new int[] { 5 };

            //Act
            var result = Maths.Instance.Maximum(myArray);

            //Assert
            Assert.Equal(result, 5);
        }
    }
}
