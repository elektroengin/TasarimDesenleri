using System;

namespace abstractV4
{
    class Program
    {
        //Abstract Class Constructor
        static void Main(string[] args)
        {
            double radius = 2;
            double height = 4;

            Circle circle = new Circle(radius);
            var circleArea = circle.Area();

            Cylinder cylinder = new Cylinder(radius, height);
            var cylinderArea = cylinder.Area();

            Console.WriteLine(circleArea);
            Console.WriteLine(cylinderArea);
            Console.ReadLine();
        }
    }
}
