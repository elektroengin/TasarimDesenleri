using System;

namespace abstractV3
{
    class Musteri
    {
        static void Main(string[] args)
        {
            //Bmw marka araçlarının üretildiği fabrika olulturduk.
            ArabaFabrika bmw = new BmwFabrika();

            //Bmw marka araçlarının üretildiği fabrika olulturduk.
            ArabaFabrika audi = new AudiFabrika();

            foreach (var item in bmw.ArabaListesi)
            {
                Console.WriteLine(item.Marka + "-" + item.Model + "-" + item.BeygirGucu);
            }

            foreach (var item in audi.ArabaListesi)
            {
                Console.WriteLine(item.Marka + "-" + item.Model + "-" + item.BeygirGucu);

            }

            Console.ReadLine();

        }
    }
}
