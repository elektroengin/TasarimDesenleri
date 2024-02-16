namespace BuilderPaternV1
{
    public class FordSiparisBuilder : SiparisBuilder
    {
        public FordSiparisBuilder() { }

        public override string Marka
        {
            set { ArabaAd.Marka = new Marka(value); }
        }
        public override string Model { set { ArabaAd.Model = new Model(value); } }
        public override int BeygirGucu { set { ArabaAd.BeygirGucu = value; } }
        public override string Renk { set { ArabaAd.Renk = value; } }
    }
}
