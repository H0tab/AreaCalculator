namespace AreaCalculator.Core
{
    public static class Calculator
    {
        public static double CalculateArea(IShape shape) => shape.GetArea();
    }
}
