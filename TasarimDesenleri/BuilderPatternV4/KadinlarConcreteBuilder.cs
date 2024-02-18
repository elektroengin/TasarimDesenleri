namespace BuilderPatternV4
{
    /// <summary>
    /// ConcreteBuilder Sınıfımız
    /// </summary>
    public class KadinlarConcreteBuilder : ProductBuilder
    {
        public KadinlarConcreteBuilder()
        {
            promosyon = new Promosyon();
        }
        public override void SetCalisanProfili()
        {
            promosyon.CalisanProfili = "Kadınlar";
        }

        public override void SetPromosyonNumarasi()
        {
            promosyon.PromosyonNumarasi = 650;
        }

        public override void SetUrunAdi()
        {
            promosyon.UrunAdi = "Pantolon";
        }
    }
}
