namespace BuilderPatternV4
{
    public abstract class ProductBuilder
    {
        /// <summary>
        /// Buiilder sınıfım
        /// </summary>
        protected Promosyon promosyon;

        public Promosyon Promosyon
        {
            get { return promosyon; }
        }

        public abstract void SetUrunAdi();
        public abstract void SetPromosyonNumarasi();
        public abstract void SetCalisanProfili();
    }
}
