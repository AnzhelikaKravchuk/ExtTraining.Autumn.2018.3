namespace No4.Solution.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var charGen = new RandomCharsFileGenerator(
                @"C:\Users\Илья\Desktop\Test",
                ".txt",
                "dsfdrhyrtdnjuyj");
            charGen.GenerateFiles(3, 20);

            var byteGen = new RandomBytesFileGenerator(
                @"C:\Users\Илья\Desktop\Test2",
                ".doc");
            byteGen.GenerateFiles(5, 60);
        }
    }
}
