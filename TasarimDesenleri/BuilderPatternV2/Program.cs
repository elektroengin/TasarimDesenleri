namespace BuilderPatternV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IArabaBuilder builder = new OpelConreteBuilder();
            ArabaUret uret = new ArabaUret();
            Araba araba = uret.Uret(builder);

            //Console.WriteLine(araba.ToString());
            Console.WriteLine($"{araba.Marka} marka araba {araba.Model} modelinde {araba.Km} kilometrede {araba.Vites} vites olarak üretilmiştir.");

        }
    }
}