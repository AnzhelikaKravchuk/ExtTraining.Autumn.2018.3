namespace No4.Solution
{
    public interface IFileGenerator
    {
        string WorkingDirectory { get; }
        string FileExtension { get; }
        void GenerateFiles(int filesCount, int contentLength);
    }
}
