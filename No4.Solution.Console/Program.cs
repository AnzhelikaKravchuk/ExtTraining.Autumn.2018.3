namespace No4.Solution.Console
{
    using System;
    using System.IO;
    
    class Program
    {
        static void Main(string[] args)
        {
            RandomBytesFileGenerator.Instance.GenerateFiles(1, 100);
            RandomCharsFileGenerator.Instance.GenerateFiles(1, 100);

            var byteFileDirectory = new DirectoryInfo(RandomBytesFileGenerator.Instance.WorkingDirectory);
            
            foreach (FileInfo byteFile in byteFileDirectory.EnumerateFiles())
            {
                Console.WriteLine(byteFile.FullName);
                Console.WriteLine(File.ReadAllText(byteFile.FullName));
            } 
            
            var charFileDirectory = new DirectoryInfo(RandomCharsFileGenerator.Instance.WorkingDirectory);
            
            foreach (FileInfo charFile in charFileDirectory.EnumerateFiles())
            {
                Console.WriteLine(charFile);
                Console.WriteLine(File.ReadAllText(charFile.FullName));
            }

            Console.WriteLine("Stopped.");
        }
    }
}
