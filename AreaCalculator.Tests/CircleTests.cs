namespace AreaCalculator.Tests
{
    public class CircleTests
    {
        [Fact]
        public void GetArea_Radius5_Return79()
        {
            //Arrange
            Circle circle = new(5);

            //Act
            var area = circle.GetArea();
            var result = Math.Round(area);

            //Assert
            Assert.Equal(79, result);
        }

        [Fact]
        public void GetArea_Radius0_Return0()
        {
            //Arrange
            Circle circle = new(0);

            //Act
            var area = circle.GetArea();
            var result = Math.Round(area);

            //Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void GetArea_RadiusMinus5_Return0()
        {
            //Arrange
            Circle circle = new(-5);

            //Act
            var area = circle.GetArea();
            var result = Math.Round(area);

            //Assert
            Assert.Equal(0, result);
        }
    }
}
