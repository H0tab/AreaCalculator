namespace AreaCalculator.Tests
{
    public class TriangleTests
    {
        [Fact]
        public void GetArea_TriangleWithSides_7_15_20_Return42()
        {
            //Arrange
            Triangle triangle = new(7, 15, 20);

            //Act
            var result = triangle.GetArea();

            //Assert
            Assert.Equal(42, result);
        }

        [Fact]
        public void GetArea_TriangleWithSides_7_15_25_Return0()
        {
            //Arrange
            Triangle triangle = new(7, 15, 25);

            //Act
            var result = triangle.GetArea();

            //Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void GetArea_TriangleWithSides_0_15_25_Return0()
        {
            //Arrange
            Triangle triangle = new(0, 15, 25);

            //Act
            var result = triangle.GetArea();

            //Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void GetArea_TriangleWithSides_minus5_15_25_Return0()
        {
            //Arrange
            Triangle triangle = new(-5, 15, 25);

            //Act
            var result = triangle.GetArea();

            //Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void GetArea_TriangleWithNegativeSides_Return0()
        {
            //Arrange
            Triangle triangle = new(-5, -10, -50);

            //Act
            var result = triangle.GetArea();

            //Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void IsRectangular_TriangleWithSides_7_24_25_ReturnTrue()
        {
            //Arrange
            Triangle triangle = new(7, 24, 25);

            //Act
            var result = triangle.IsRectangular();

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void IsRectangular_TriangleWithSides_6_8_10_ReturnTrue()
        {
            //Arrange
            Triangle triangle = new(6, 8, 10);

            //Act
            var result = triangle.IsRectangular();

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void IsRectangular_TriangleWithSides_0_8_10_ReturnFalse()
        {
            //Arrange
            Triangle triangle = new(0, 8, 10);

            //Act
            var result = triangle.IsRectangular();

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void IsRectangular_TriangleWithSides_10_8_10_ReturnFalse()
        {
            //Arrange
            Triangle triangle = new(10, 8, 10);

            //Act
            var result = triangle.IsRectangular();

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void IsRectangular_TriangleWithNegativeSides_ReturnFalse()
        {
            //Arrange
            Triangle triangle = new(-6, -15, -10);

            //Act
            var result = triangle.IsRectangular();

            //Assert
            Assert.False(result);
        }
    }
}
