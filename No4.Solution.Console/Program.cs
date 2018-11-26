namespace No4.Solution.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomFileGenerator randomBytesFileGenerator = new RandomFileGenerator(
                "./", ".txt", new ByteWriter(), new ByteContentGenerator());

            RandomFileGenerator randomCharFileGenerator = new RandomFileGenerator(
                "./", ".txt", new ByteWriter(), new CharContentGenerator());

            randomBytesFileGenerator.GenerateFiles(1, 10);
            randomCharFileGenerator.GenerateFiles(1, 5);
        }
    }
}
