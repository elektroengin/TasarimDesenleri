using System;

namespace abstractV5
{
    public class Word : IDocument
    {
        public void Close()
        {
            throw new NotImplementedException();
        }

        public string GetDocumentType()
        {
            return "Word";
        }

        public void Open()
        {
            throw new NotImplementedException();
        }
    }
}
