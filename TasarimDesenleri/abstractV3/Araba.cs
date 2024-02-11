namespace abstractV3
{
    public abstract class Araba
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public int BeygirGucu { get; set; }

        public Araba(string marka, string model, int beygirGucu)
        {
            this.Marka = marka;
            this.Model = model;
            this.BeygirGucu = beygirGucu;
        }
    }
}
