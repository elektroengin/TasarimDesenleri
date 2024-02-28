namespace LSPV1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Ferrari();
            car.Run();
            car.OpenAirCondition();

            car = new Tofas();
            car.Run();
            car.OpenAirCondition();

        }
    }
}