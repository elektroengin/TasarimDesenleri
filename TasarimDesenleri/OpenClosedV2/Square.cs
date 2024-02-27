namespace OpenClosedV2
{
    public class Square : Shape
    {
        public int lenght;
        public override double Area()
        {
            return lenght * lenght;
        }
    }
}
