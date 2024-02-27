namespace OpenClosedV1
{
    /// <summary>
    /// Değişime Kapalı değil Sürekli yeni isteklerde müdehale ediyoruz.
    /// </summary>
    public class AreaCalculator
    {
        public double Area(object shape)
        {
            double area = 0;
            if (shape is Rectangle)
            {
                Rectangle rectangle = (Rectangle)shape;
                area = rectangle.Height * rectangle.Weight;
            }
            else if (shape is Square)
            {
                Square square = (Square)shape;
                area = square.Height * square.Height;
            }
            else if (shape is Circle)
            {
                Circle circle = (Circle)shape;
                area = Math.PI * circle.radius * circle.radius ;
            }

            return area;
        }
    }
}
