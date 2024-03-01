namespace LSV1Hatali
{
    internal class Program
    {
        /// <summary>
        ///User,UserRole
        ///Order,Product,Pay
        ///
        ///
        ///
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Repository repository = new Repository();
            repository.GetOrderId(1);


            Console.WriteLine("Hello, World!");
        }
    }
}