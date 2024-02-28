using System.Reflection;

namespace LSPV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Ferrari car = new Ferrari();
            Console.WriteLine(car.Run());
            car.OpenAirCondition();
            
            
            Tofas tofas = new Tofas();
            Console.WriteLine(tofas.Run());
        }
    }
}