namespace No4.Solution.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            IFileGenerator[] generators = { new RandomBytesFileGenerator(), new RandomCharsFileGenerator() };
            foreach (var generator in generators)
            {
                GenerateFiles(generator, 10, 10);
            }

            System.Console.ReadLine();
        }

        static void GenerateFiles(IFileGenerator generator, int count, int length)
        {
            generator.GenerateFiles(count, length);
            System.Console.WriteLine($"Was generated {count} files, {length} length each in directory \"{generator.WorkingDirectory}\". Files have extension \"{generator.FileExtension}\"");
        }
    }
}
