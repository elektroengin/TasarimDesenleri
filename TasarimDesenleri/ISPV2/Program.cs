namespace ISPV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserRepository user = new UserRepository();
            user.GetUserList();

            ProductRepository repository = new ProductRepository();
            repository.GetProductId(1);

            
        }
    }
}