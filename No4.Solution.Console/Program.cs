namespace No4.Solution.Console
{
    using System;
    using System.Diagnostics;

    using No4.Solution.FileContent;
    using No4.Solution.FileName;

    class Program
    {
        static void Main(string[] args)
        {
            int countOfFiles;
            int contentLength;

            Console.WriteLine("Enter number of files");
            while (!int.TryParse(System.Console.ReadLine(), out countOfFiles))
            {
                Console.WriteLine("Wrong input!");
            }

            Console.WriteLine("Enter content length");
            while (!int.TryParse(System.Console.ReadLine(), out contentLength))
            {
                Console.WriteLine("Wrong input!");
            }

            RandomFileGenerator byteFileGenerator = new RandomFileGenerator(new BytesContentGenerator(), new GuidFileNameGenerator());
            
            byteFileGenerator.WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory + "ByteFileFolder";
            byteFileGenerator.GenerateFiles(countOfFiles, contentLength);

            Console.WriteLine("File has been created!");

            Console.WriteLine("Enter number of files");
            while (!int.TryParse(System.Console.ReadLine(), out countOfFiles))
            {
                Console.WriteLine("Wrong input!");
            }

            Console.WriteLine("Enter content length");
            while (!int.TryParse(System.Console.ReadLine(), out contentLength))
            {
                Console.WriteLine("Wrong input!");
            }

            RandomFileGenerator charsFileGenerator = new RandomFileGenerator(new CharsContentGenerator(), new GuidFileNameGenerator(".txt"));

            charsFileGenerator.WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory + "CharsFileFolder";
            charsFileGenerator.GenerateFiles(countOfFiles, contentLength);

            Console.WriteLine("File has been created!");

            System.Console.ReadKey();
        }
    }
}
