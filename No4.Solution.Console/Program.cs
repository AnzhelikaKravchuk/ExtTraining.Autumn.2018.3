namespace No4.Solution.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomCharsGenerator charsGenerator = new RandomCharsGenerator();
            RandomBytesGenerator bytesGenerator = new RandomBytesGenerator();

            charsGenerator.GenerateFiles(1, 10);
            bytesGenerator.GenerateFiles(2, 30);
        }
    }
}
