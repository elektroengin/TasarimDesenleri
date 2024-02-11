namespace AbstractFactory
{
    class ConcreteFactoryImp2 : IAbstractFactory
    {
        #region IAbstractFactory Members

        public IElma GetElma()
        {
            return new YesilElma();
        }

        public IBiber GetBiber()
        {
            return new YesilBiber();
        }

        #endregion
    }
}
