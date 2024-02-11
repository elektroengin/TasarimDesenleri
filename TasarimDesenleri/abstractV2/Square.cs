namespace abstractV2
{
    public class Square : Shape
    {
        private int side;

        public Square(int x)
        {
            side = x;
        }

        public override int GetArea()
        {
            return side * side;
        }

        public override int Getperimeter()
        {
            return 4 * side;
        }
    }
}
