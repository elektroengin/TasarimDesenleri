namespace BuilderPatternV4
{
    /// <summary>
    /// ConcreteBuilder Sınıfımız
    /// </summary>
    public class IscilerConcreteBuilder : ProductBuilder
    {
        public IscilerConcreteBuilder()
        {
            promosyon = new Promosyon();
        }
        public override void SetCalisanProfili()
        {
            promosyon.CalisanProfili = "İşçiler";
        }

        public override void SetPromosyonNumarasi()
        {
            promosyon.PromosyonNumarasi = 170;
        }

        public override void SetUrunAdi()
        {
            promosyon.UrunAdi = "Ceket";
        }
    }
}
