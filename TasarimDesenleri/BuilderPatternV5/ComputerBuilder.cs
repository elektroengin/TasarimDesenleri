namespace BuilderPatternV5
{
    /// <summary>
    /// Builder'ımız
    /// </summary>
    public abstract class ComputerBuilder
    {
        public Computer computer { get; set; }

        public abstract void ComputerType();
        public abstract void BuildHardisk();
        public abstract void BuildMotherBoard();
        public abstract void BuildProcessor();
        public abstract void BuildScreen();
    }
}
