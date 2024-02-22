namespace BuilderPatternV5
{
    /// <summary>
    /// Director
    /// </summary>
    public class ComputerShop
    {
        public ComputerShop(ComputerBuilder builder)
        {
            builder.ComputerType();
            builder.BuildHardisk();
            builder.BuildMotherBoard();
            builder.BuildProcessor();
            builder.BuildScreen();
        }
    }
}
