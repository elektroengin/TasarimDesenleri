namespace AbstractFactory
{
    public class KirmiziElma : IElma
    {
        #region IElma Members

        public new string GetType()
        {
            return "Kirmizi Elma";
        }

        #endregion
    }
}
