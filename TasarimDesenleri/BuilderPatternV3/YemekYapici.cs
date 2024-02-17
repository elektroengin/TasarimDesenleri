namespace BuilderPatternV3
{
    /// <summary>
    /// Director Sınıfımız
    /// </summary>
    public class YemekYapici
    {
        public void YemekYap(YemekBuilder builder)
        {
            builder.SetYemekAdi();
            builder.SetYemekTipi();
            builder.SetTuz();
        }

    }
}
