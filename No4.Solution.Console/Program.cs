namespace No4.Solution.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomFileGenerator fileGenerator = new RandomBytesFileGenerator();
            fileGenerator.GenerateFiles(1, 3);

            fileGenerator.GenerateFiles(5, 10);

            fileGenerator = new RandomCharsFileGenerator();
            fileGenerator.GenerateFiles(5, 15);
        }
    }
}
