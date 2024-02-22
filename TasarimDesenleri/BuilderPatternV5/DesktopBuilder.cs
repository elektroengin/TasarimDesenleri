namespace BuilderPatternV5
{
    public class DesktopBuilder : ComputerBuilder
    {
        public DesktopBuilder()
        {
            computer = new Computer();
        }
        public override void BuildHardisk()
        {
            computer.Harddisk = "2TB";
        }

        public override void BuildMotherBoard()
        {
            computer.MotherBoard = "Intel Motherboard";
        }

        public override void BuildProcessor()
        {
            computer.Processor = "Intel i9";
        }

        public override void BuildScreen()
        {
            computer.Screen = "LG 34WQ650";
        }

        public override void ComputerType()
        {
            computer.ComputerType = "Desktop";
        }
    }
}
