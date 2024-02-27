namespace OpenClosedV2
{
    public class Circle : Shape
    {
        public int radius;
        public override double Area()
        {
            return Math.PI * radius * radius;

        }
    }
}
