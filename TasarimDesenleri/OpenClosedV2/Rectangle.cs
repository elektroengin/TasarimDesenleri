namespace OpenClosedV2
{
    public class Rectangle : Shape
    {
        public int Weight { get; set; }
        public int Height { get; set; }

        public override double Area()
        {
            return Weight* Height;
        }
    }
}
