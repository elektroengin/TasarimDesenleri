using System;

namespace abstractV5
{
    public class DocumentFactory
    {
        public static IDocument CreateDocument(string type)
        {
            if (type.Equals("PDF"))
            {
                return new Pdf();
            }
            else if (type.Equals("WORD"))
            {
                return new Word();
            }
            else
            {
                throw new Exception("Unsuported Document");
            }
        }
    }
}
