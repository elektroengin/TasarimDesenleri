namespace BuilderPaternV1
{

    /// <summary>
    ///     Arabanın Modeli
    /// </summary>
    public class Model
    {
        public string Ad { get; set; }

        public Model(string ad) { 
            Ad = ad;
        }
        public override string ToString()
        {
            return Ad;
        }
    }
}
