namespace BuilderPatternV2
{
    /// <summary>
    /// Arabayı üretecek olan Opel,Toyotave Bmw gibi biribirlerinden
    /// farklı özellik teşkil eden tüm sınıflarımız ConcreteBuilder Sınıfı olacaktır.
    /// </summary>
    public class Araba
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public double Km { get; set; }
        public bool Vites { get; set; }

        public override string ToString()
        {
            return $"{Marka} marka araba {Model} modelinde {Km} kilometrede {Vites} vites olarak üretilmiştir.";
        }
    }
}
