namespace BuilderPatternV4
{
    /// <summary>
    /// ConcreteBuilder Sınıfımız
    /// </summary>
    public class AmirlerConcreteBuilder : ProductBuilder
    {
        public AmirlerConcreteBuilder()
        {
            promosyon = new Promosyon();
        }
        public override void SetCalisanProfili()
        {
            promosyon.CalisanProfili = "Amirler";
        }

        public override void SetPromosyonNumarasi()
        {
            promosyon.PromosyonNumarasi = 90;
        }

        public override void SetUrunAdi()
        {
            promosyon.UrunAdi = "Gomlek";
        }
    }
}
