namespace BuilderPatternV3
{
    internal class Program
    {
        /// <summary>
        /// AKIŞ : /// Product -> Builder -> Concrete Builder -> Director -> Client
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            YemekBuilder builder = new SuluYemekConcreteBuilder();
            YemekYapici yemekYapici = new YemekYapici();

            yemekYapici.YemekYap(builder);
            Console.WriteLine(builder.Yemek.ToString());

            builder = new EtliYemekConcreteBuilder();
            yemekYapici.YemekYap(builder);
            Console.WriteLine(builder.Yemek.ToString());

            builder = new SebzeliYemekConcreteBuilder();
            yemekYapici.YemekYap(builder);
            Console.WriteLine(builder.Yemek.ToString());


        }
    }
}