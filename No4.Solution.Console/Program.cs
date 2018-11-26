namespace No4.Solution.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomCharsFileGenerator generator = new RandomCharsFileGenerator("Files with random chars", ".txt");
            RandomBytesFileGenerator generator2 = new RandomBytesFileGenerator("Files with random bytes", ".bytes");

            generator.GenerateFile(1, 10);
            generator2.GenerateFile(1, 10);
        }
    }
}
