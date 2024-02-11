using System;

namespace abstractV1
{
    class Program
    {
        static void Main(string[] args)
        {
            Bolme bolme = new Bolme();
            var restult = bolme.Hesapla(3 , 1);

            Cikarma cikarma = new Cikarma();
            var cikarResult = cikarma.Hesapla(3, 1);

            Console.WriteLine(restult);
            Console.WriteLine(cikarResult);
            Console.ReadLine();
        }
    }
}
