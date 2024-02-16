namespace BuilderPaternV1
{
    /// <summary>
    /// Arabanın Modeli
    /// </summary>
    /// <param name="ad"></param>

    public class Marka 
    {
        public string Ad { get; set; }

        public Marka(string ad) {
            Ad = ad;    
        }
        
        public override string ToString()
        {
            return Ad;
        }
    }    

}
