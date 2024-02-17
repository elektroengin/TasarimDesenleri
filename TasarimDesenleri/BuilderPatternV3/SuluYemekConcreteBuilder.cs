namespace BuilderPatternV3
{
    /// <summary>
    /// ConcreteBuilder Sınıfımız
    /// </summary>
    public class SuluYemekConcreteBuilder : YemekBuilder
    {
        public SuluYemekConcreteBuilder()
        {
            yemek = new Yemek();
        }
        public override void SetTuz()
        {
            yemek.Tuz = 10;
        }

        public override void SetYemekAdi()
        {
            yemek.YemekAdi = "Tarhana";
        }

        public override void SetYemekTipi()
        {
            yemek.YemekTipi = YemekTipi.Sulu;
        }
    }
}
