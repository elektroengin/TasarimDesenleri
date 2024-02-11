namespace abstractV5
{
    public interface IDocument
    {
        void Open();
        void Close();
        string GetDocumentType();
    }
}
