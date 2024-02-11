using System;

namespace abstractV5
{
    public class Pdf : IDocument
    {
        public void Close()
        {
            throw new NotImplementedException();
        }

        public string GetDocumentType()
        {
            return "Pdf";
        }

        public void Open()
        {
            throw new NotImplementedException();
        }
    }
}
