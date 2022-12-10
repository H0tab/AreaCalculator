namespace AreaCalculator.Tests
{
    public class CircleTests
    {
        [Theory]
        [InlineData(1)]
        [InlineData(13)]
        [InlineData(50.5)]
        public void GetArea_CircleWithValidRadius_ReturnExpectedArea(double radius)
        {
            var circle = new Circle(radius);

            var area = circle.GetArea();
            var expectedArea = Math.PI * Math.Pow(radius, 2);

            Assert.Equal(expectedArea, area);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(-50.5)]
        public void GetArea_CircleWithInvalidRadius_Return0(double radius)
        {
            var circle = new Circle(radius);

            var area = circle.GetArea();

            Assert.Equal(0, area);
        }
    }
}
