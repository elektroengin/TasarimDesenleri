namespace BuilderPatternV5
{
    /// <summary>
    /// Product kısmımız
    /// </summary>
    public class Computer
    {

        public string ComputerType { get; set; } //Enum olacak şekilde
        public string Harddisk { get; set; }
        public string MotherBoard { get; set; } 
        public string Processor { get; set; }
        public string Screen { get; set; }

        public void DisplayConfiguration()
        {
            string message;

            message = String.Format("Computer : {0}", ComputerType);
            Console.WriteLine(message);

            message = String.Format("Harddisk : {0}", Harddisk);
            Console.WriteLine(message);

            message = String.Format("MotherBoard : {0}", MotherBoard);
            Console.WriteLine(message);

            message = String.Format("Processor : {0}", Processor);
            Console.WriteLine(message);

            message = String.Format("Screen : {0}", Screen);
            Console.WriteLine(message);

            Console.WriteLine();
        }

    }
}
