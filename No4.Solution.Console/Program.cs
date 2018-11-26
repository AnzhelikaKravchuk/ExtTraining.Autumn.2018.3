namespace No4.Solution.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomBytesFileGenerator bytesGenerator = new RandomBytesFileGenerator();
            bytesGenerator.GenerateFiles(1, 23);
            RandomCharsFileGenerator charsGenerator = new RandomCharsFileGenerator();
            charsGenerator.GenerateFiles(1, 23);

            System.Console.ReadKey();
        }
    }
}
