using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            //IAbstractFactory arayüzünü uygulayan
            //ConcreteFactorylmp1 sinifi kullaniliyor... 
            IAbstractFactory factory = new ConcreteFactoryImp1();
            IElma elma = factory.GetElma();
            IBiber biber = factory.GetBiber();
            Console.WriteLine(elma.GetType());
            Console.WriteLine(biber.GetType());

            //IAbstractFactory arayüzünü uygulayan
            //ConcreteFactorylmp2 sinifi kullaniliyor...
            factory = new ConcreteFactoryImp2();
            elma = factory.GetElma();
            biber = factory.GetBiber();
            Console.WriteLine(elma.GetType());
            Console.WriteLine(biber.GetType());

        }
    }
}
