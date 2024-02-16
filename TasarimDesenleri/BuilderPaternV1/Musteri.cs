namespace BuilderPaternV1
{
    internal class Musteri
    {
        static void Main(string[] args)
        {
            SiparisManager siparisManager =  new SiparisManager();

            var ilkArabam = siparisManager.CreateOrder("Audi", "A8", "Gri", 1600);
            siparisManager.PrintOder();

            var ikinciArabam = siparisManager.CreateOrder("Bmw", "Z", "Beyaz", 1600);
            siparisManager.PrintOder();

            Console.Read();

        }
    }
}

//Singleton
//RepositoryPattern
//EntityFramework

//Diğer design pattern

//CQRS pattern

//Bootstrap,Javascript
//WCF,Rest Servisi
//MSMQ,RabbitMQ,Kafka
