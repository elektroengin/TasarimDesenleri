namespace SolidV2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var invoice = new Invoice
            {
                FaturaNo = "232323",
                FataraTutari = 121,
                FirstName = "eeddede"
            };

            QueryRepository query = new QueryRepository();
            query.Query(invoice);

            int response =  CommandRepository.CommandInvoice(invoice);
            //command.CommandInvoice(invoice);
        }
    }
}