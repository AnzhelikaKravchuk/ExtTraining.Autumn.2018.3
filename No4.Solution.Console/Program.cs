namespace No4.Solution.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomFileGenerator randomFileGenerator = new RandomBytesFileGenerator();
            int filesCount = 4, contentLength = 20;

            randomFileGenerator.GenerateFiles(filesCount, contentLength);

            randomFileGenerator = new RandomCharsFileGenerator();

            randomFileGenerator.GenerateFiles(filesCount, contentLength);
        }
    }
}
