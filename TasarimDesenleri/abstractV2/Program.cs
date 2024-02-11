using System;

namespace abstractV2
{
    class Program
    {
        static void Main(string[] args)
        {
            Square shape = new Square(6);
            var sonuc = shape.GetArea();

            Triangle triangle = new Triangle(6, 2);
            var tresult = triangle.GetArea();

            Rectanguler rectanguler = new Rectanguler(7, 5);
            var recResult = rectanguler.GetArea();
            var recRecultCevre = rectanguler.Getperimeter();

            Console.WriteLine("Square: {0}", sonuc);
            Console.WriteLine("Triangle:{0}", tresult);
            Console.WriteLine("Rectanguler:{0}", tresult);
            Console.WriteLine("recRecultCevre:{0}", recRecultCevre);
            Console.ReadLine();
        }
    }
}
