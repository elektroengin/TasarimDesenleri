using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternV5
{
    /// <summary>
    /// Concrete Builder
    /// </summary>
    public class LaptopBuilder : ComputerBuilder
    {
        public LaptopBuilder()
        {
            computer = new Computer();
        }
        public override void BuildHardisk()
        {
            computer.Harddisk = "500GB";
        }

        public override void BuildMotherBoard()
        {
            computer.MotherBoard = "AMD Motherboard";
        }

        public override void BuildProcessor()
        {
            computer.Processor = "XEON 5452";
        }

        public override void BuildScreen()
        {
            computer.Screen = "LG 34WQ650";
        }

        public override void ComputerType()
        {
            computer.ComputerType = "Notebook";
        }
    }
}
