namespace GenericTypesSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Generic Method
            GenericMethodExam exam = new GenericMethodExam();

            int resultInt = exam.GenericMethod(5);
            string resultString = exam.GenericMethod("Şamil/Yiğit");

            //En çok kullanışan Yöntem.
            var test2 = exam.GenericMethod<int>(5);
            var test3 = exam.GenericMethod<string>("Hello");

            Console.WriteLine(resultInt);
            Console.WriteLine(resultString);

            //2. Generic Class
            GenericMethodClass<int> testInt = new GenericMethodClass<int>(6);
            var test4 = testInt.Data();

                
            GenericMethodClass<string> testString = new GenericMethodClass<string>("Hello world");
            var test5 = testString.Data();

            Console.WriteLine(test4);
            Console.WriteLine(test5);



        }
    }
}