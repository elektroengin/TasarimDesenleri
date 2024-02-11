namespace AbstractFactory
{
    public class YesilBiber : IBiber
    {
        #region IBiber Members

        public new string GetType()
        {
            return "Yeşil Biber";
        }

        #endregion
    }
}
