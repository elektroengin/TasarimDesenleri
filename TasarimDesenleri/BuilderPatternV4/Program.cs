namespace BuilderPatternV4
{
    /// <summary>
    /// Client'ımız
    /// AKIŞ : /// Product -> Builder -> Concrete Builder -> Director -> Client
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductBuilder promosyon = new AmirlerConcreteBuilder();
            PromosyonGonder gonder = new PromosyonGonder();
            gonder.Gonder(promosyon);
            promosyon.Promosyon.ToString();

            promosyon = new KadinlarConcreteBuilder();
            gonder.Gonder(promosyon);
            promosyon.Promosyon.ToString();

            promosyon = new IscilerConcreteBuilder();
            gonder.Gonder(promosyon);
            promosyon.Promosyon.ToString();

        }
    }
}