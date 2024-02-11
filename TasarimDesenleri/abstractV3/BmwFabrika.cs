namespace abstractV3
{
    //Bmw marka arabaları üretir.
    //ArabaFabrika sınıfından alt sınıfı olduğu için CreateAuto()
    //metodunu implemente eder
    public class BmwFabrika : ArabaFabrika
    {
        //ArabaFabrika sınıfında yapılan
        //createauto() metodu Bmw altsınıfındaki
        //bilgileri implenete eder.Audi markasına ait
        //Z4 modelerinin üretiminde kullanılır.
        public override void CreateAuto()
        {
            base.ArabaListesi.Add(new BmwZ4(1600));
            base.ArabaListesi.Add(new BmwZ4(1800));
            base.ArabaListesi.Add(new BmwZ4(2000));
        }
    }
}
