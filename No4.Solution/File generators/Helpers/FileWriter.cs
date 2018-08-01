using System.IO;

namespace No4.Solution.File_generators.Helpers
{
    public static class FileWriter
    {
        public static void WriteBytes(string fileName, byte[] content, string directory)
        {
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            File.WriteAllBytes($"{directory}//{fileName}", content);
        }
    }
}
