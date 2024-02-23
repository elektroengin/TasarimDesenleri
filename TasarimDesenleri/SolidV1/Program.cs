namespace SolidV1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Database database1 = Database.GetInstance();
            Database database2 = Database.GetInstance();

            bool isEquals = database1.Equals(database2);
            
            Console.WriteLine($"Database reference is equals : {isEquals}");

        }
    }
}