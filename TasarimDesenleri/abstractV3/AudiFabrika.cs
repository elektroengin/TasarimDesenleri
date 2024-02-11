namespace abstractV3
{
    //Audi marka arabaları üretir.
    //ArabaFabrika sınıfından alt sınıfı olduğu için CreateAuto()
    //metodunu implemente eder
    public class AudiFabrika : ArabaFabrika
    {
        //ArabaFabrika sınıfında yapılan
        //createauto() metodu Audi altsınıfındaki
        //bilgileri implenete eder.Audi markasına ait
        //A4 ve R8 modelerinin üretiminde kullanılır.
        public override void CreateAuto()
        {
            base.ArabaListesi.Add(new AudiA4(1600));
            base.ArabaListesi.Add(new AudiA4(1800));
        }
    }
}
