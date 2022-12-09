namespace AreaCalculator.Core
{
    public class Triangle : IShape
    {
        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public double A { get; init; }
        public double B { get; init; }
        public double C { get; init; }
        public double Perimeter => (A + B + C) / 2;
        public bool IsExists => (A + B) > C && (B + C) > A && (C + A) > B;

        /// <summary>
        /// If triangle exists, returns the area of triangle otherwise returns 0
        /// </summary>
        /// <returns></returns>
        public double GetArea()
        {
            if (IsExists)
            {
                return Math.Sqrt(Perimeter * (Perimeter - A) * (Perimeter - B) * (Perimeter - C));
            }

            return 0;
        }

        /// <summary>
        /// Returns true if triangle is rectangular
        /// </summary>
        /// <returns></returns>
        public bool IsRectangular()
        {
            var sqA = Math.Pow(A, 2);
            var sqB = Math.Pow(B, 2);
            var sqC = Math.Pow(C, 2);

            if (IsExists)
            {
                return (sqA + sqB == sqC) ||
                       (sqA + sqC == sqB) ||
                       (sqC + sqB == sqA);
            }

            return false;
        }

    }
}
