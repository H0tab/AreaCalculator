using AreaCalculator.Core;

Triangle triangle1 = new(7, 15, 20);
Triangle triangle2 = new(13, 30, 42);
Circle circle1 = new(2);
Circle circle2 = new(10);

Console.WriteLine(Calculator.CalculateArea(triangle1));