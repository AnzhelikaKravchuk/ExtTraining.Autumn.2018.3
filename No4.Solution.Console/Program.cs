namespace No4.Solution.Console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            RandomFileGenerator charFile = new RandomCharsFileGenerator();

            charFile.GenerateFiles(1, 5);

            RandomFileGenerator bytesFile = new RandomBytesFileGenerator();

            bytesFile.GenerateFiles(1, 5);
        }
    }
}
