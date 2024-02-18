namespace BuilderPatternV4
{
    /// <summary>
    /// Builder Sınıfımız
    /// </summary>
    public class PromosyonGonder
    {
        public void Gonder(ProductBuilder builder)
        {
            builder.SetCalisanProfili();
            builder.SetPromosyonNumarasi();
            builder.SetUrunAdi();
        }
    }
}
