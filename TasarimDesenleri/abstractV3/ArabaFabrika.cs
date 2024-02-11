using System.Collections.Generic;

namespace abstractV3
{
    //Genel bir araba fabrikasını tanımlar. Abstract olduğu için bu sınıftan nesneler
    //üretilemiz. Belirli bir araba marka,model ve beygir gücü modellerini üretebilmek için
    //bu sınıfın altsınıfı oluşturulması gerekmektedir.
    public abstract class ArabaFabrika
    {

        //Aynı araca ait 1 den fazla araba üretebilirim Bir araba fabrikasının ürettiği 
        //değişik modelledeki arabaların içinde bulunduğu liste
        public List<Araba> arabaList = new List<Araba>();
        public List<Araba> ArabaListesi
        {
            get { return arabaList; }
            set { arabaList = value; }
        }

        //Genel Araba fabrikasında araç üretimine başlamış olunur.
        public ArabaFabrika()
        {
            this.CreateAuto();
        }

        //Alt sınıflar tarafından implemente edilir. 
        //Belirli bir marka , model ve beygirgücü araçlarının oluşturulmasında kullanılır.
        public abstract void CreateAuto();

    }
}
