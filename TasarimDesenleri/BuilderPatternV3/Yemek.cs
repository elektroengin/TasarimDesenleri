namespace BuilderPatternV3
{
    /// <summary>
    /// Yemek Classımız (Product)
    /// </summary>
    public enum YemekTipi
    {
        Sulu, Etli, Sebzeli
    }
    public class Yemek
    {
        public YemekTipi YemekTipi { get; set; }
        public string YemekAdi { get; set; }
        public int Tuz { get; set; }

        public override string ToString()
        {
            return $"{YemekAdi} -> {YemekTipi} -> Tuz Oranı : {Tuz}";
        }
    }
}
