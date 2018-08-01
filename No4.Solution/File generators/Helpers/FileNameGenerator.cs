using System;

namespace No4.Solution.File_generators.Helpers
{
    public static class FileNameGenerator
    {
        public static string Generate(string fileExtension)
        {
            if (string.IsNullOrEmpty(fileExtension))
            {
                throw new ArgumentException($"{nameof(fileExtension)} can't be equal to null or empty!");
            }

            return $"{Guid.NewGuid()}{fileExtension}";
        }
    }
}
