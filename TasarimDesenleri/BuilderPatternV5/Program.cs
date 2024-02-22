namespace BuilderPatternV5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ComputerBuilder builder = new LaptopBuilder();
            ComputerShop shop = new ComputerShop(builder);

            builder.computer.DisplayConfiguration();

            builder = new DesktopBuilder();
            ComputerShop shop2 = new ComputerShop(builder);
            builder.computer.DisplayConfiguration();

            Console.ReadLine();

        }
    }
}