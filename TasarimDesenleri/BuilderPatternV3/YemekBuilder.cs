namespace BuilderPatternV3
{
    /// <summary>
    /// Builder Sınıfımız
    /// </summary>
    /// Product -> Builder -> Concrete Builder -> Director -> Client
    public abstract class YemekBuilder
    {
        protected Yemek yemek;

        public Yemek Yemek
        {
            get { return yemek; }
        }

        public abstract void SetYemekTipi();
        public abstract void SetYemekAdi();
        public abstract void SetTuz();
    }
}
