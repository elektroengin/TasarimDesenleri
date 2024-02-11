namespace AbstractFactory
{
    public class YesilElma : IElma
    {
        #region IElma Members

        public new string GetType()
        {
            return "Yeşil Elma";
        }

        #endregion
    }
}
