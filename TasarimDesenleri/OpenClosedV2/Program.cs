namespace OpenClosedV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Weight = 1;
            rectangle.Height = 10;
            AreaCalculator areaCalculator = new AreaCalculator();
            Console.WriteLine(areaCalculator.Area(rectangle));

            Circle circle = new Circle();
            circle.radius = 10;
            AreaCalculator areaCalculator2 = new AreaCalculator();
            Console.WriteLine(areaCalculator2.Area(circle));

            Console.ReadLine();
        }
    }
}