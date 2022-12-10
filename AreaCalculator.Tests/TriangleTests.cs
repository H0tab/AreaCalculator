namespace AreaCalculator.Tests
{
    public class TriangleTests
    {
        [Theory]
        [InlineData(7, 15, 20, 42)]
        [InlineData(3, 4, 5, 6)]
        [InlineData(5, 5, 8, 12)]
        public void GetArea_TriangleWithValidSides_ReturnExpectedArea(double a, double b, double c, double expectedArea)
        {
            var triangle = new Triangle(a, b, c);

            var area = triangle.GetArea();

            Assert.Equal(expectedArea, area);
        }

        [Theory]
        [InlineData(15, -22, 30)]
        [InlineData(-10, -8, -12)]
        [InlineData(1, 10, 50)]
        [InlineData(0, 13, 26)]
        [InlineData(0, 0, 0)]
        public void GetArea_TriangleWithInvalidSides_Return0(double a, double b, double c)
        {
            var triangle = new Triangle(a, b, c);

            var area = triangle.GetArea();

            Assert.Equal(0, area);
        }

        [Theory]
        [InlineData(6, 8, 10)]
        [InlineData(9, 12, 15)]
        [InlineData(10, 24, 26)]
        public void IsRectangular_RectangularTriangle_ReturnTrue(double a, double b, double c)
        {
            var triangle = new Triangle(a, b, c);

            var isRectangularTriangle = triangle.IsRectangular();

            Assert.True(isRectangularTriangle);
        }

        [Theory]
        [InlineData(5, 6, 7)]
        [InlineData(3, 4, 6)]
        [InlineData(9, 11, 13)]
        public void IsRectangular_TriangleIsNotRectangular_ReturnFalse(double a, double b, double c)
        {
            var triangle = new Triangle(a, b, c);

            var isRectangularTriangle = triangle.IsRectangular();

            Assert.False(isRectangularTriangle);
        }

        [Theory]
        [InlineData(20, 30, -10)]
        [InlineData(-5, -14, -4)]
        [InlineData(0, 32, 17)]
        [InlineData(0, 0, 0)]
        public void IsRectangular_TriangleWithInvalidSides_ReturnFalse(double a, double b, double c)
        {
            var triangle = new Triangle(a, b, c);

            var isRectangularTriangle = triangle.IsRectangular();

            Assert.False(isRectangularTriangle);
        }
    }
}
