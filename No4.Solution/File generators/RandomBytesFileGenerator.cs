using No4.Solution.Content_generators;
using No4.Solution.File_generators.Helpers;

namespace No4.Solution.File_generators
{
    public class RandomBytesFileGenerator : FileGenerator
    {
        protected override string WorkingDirectory => "Files with random bytes";

        protected override string FileExtension => ".txt";

        protected override void InnerFileGeneration(int filesCount, int contentLength)
        {
            for (int i = 0; i < filesCount; i++)
            {
                byte[] generatedFileContent = new ByteContentGenerator().GenerateFileContent(contentLength);
                string generatedFileName = FileNameGenerator.Generate(FileExtension);
                FileWriter.WriteBytes(generatedFileName, generatedFileContent, WorkingDirectory);
            }
        }
    }
}
