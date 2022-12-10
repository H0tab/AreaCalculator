namespace AreaCalculator.Core
{
    public class Circle : IShape
    {
        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Radius { get; init; }

        /// <summary>
        /// Returns the area of circle
        /// </summary>
        /// <returns></returns>
        public double GetArea()
        {
            if (Radius <= 0)
            {
                return 0;
            }

            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
