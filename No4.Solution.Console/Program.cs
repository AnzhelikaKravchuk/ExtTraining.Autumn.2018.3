namespace No4.Solution.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomBytesFileGenerator bytesFileGenerator = new RandomBytesFileGenerator();
            RandomCharsFileGenerator charsFileGenerator = new RandomCharsFileGenerator();
            bytesFileGenerator.GenerateFiles(2, 15);
            charsFileGenerator.GenerateFiles(3, 1);
        }
    }
}
