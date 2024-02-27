namespace OpenClosedV2
{
    public class AreaCalculator
    {
        /// <summary>
        /// Değişime Kapalı olacak
        /// </summary>
        /// <param name="shape"></param>
        /// <returns></returns>
        public double Area(Shape shape)
        {
            double area = 0;

            area = shape.Area();

            return area;
        }
    }
}
