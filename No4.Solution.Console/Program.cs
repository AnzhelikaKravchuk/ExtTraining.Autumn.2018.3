namespace No4.Solution.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            BytesGenerate bytes = new BytesGenerate();
            bytes.GenerateFiles(1,1);

            CharsGenerate chars = new CharsGenerate();
            chars.GenerateFiles(1, 1);
        }
    }
}
