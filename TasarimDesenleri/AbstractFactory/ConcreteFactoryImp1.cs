namespace AbstractFactory
{
    class ConcreteFactoryImp1 : IAbstractFactory
    {
        #region IAbstractFactory Members

        public IElma GetElma()
        {
            return new KirmiziElma();
        }

        public IBiber GetBiber()
        {
            return new DolmaBiber();
        }

        #endregion
    }
}
