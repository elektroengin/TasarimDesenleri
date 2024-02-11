using System;

namespace abstractV5
{
    class Program
    {
        static void Main(string[] args)
        {
            IDocument document = DocumentFactory.CreateDocument("WORD");            
            Console.WriteLine(document.GetDocumentType());
        }
    }
}
