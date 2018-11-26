using System;
using System.IO;

namespace No4.Solution
{
	public abstract class FileGeneratorBase
	{
		public abstract string WorkingDirectory { get; }

		public abstract string FileExtension { get; }

		public virtual void GenerateFiles(int filesCount, int contentLength)
		{
			for (var i = 0; i < filesCount; ++i)
			{
				var generatedFileContent = this.GenerateFileContent(contentLength);

				var generatedFileName = $"{Guid.NewGuid()}{this.FileExtension}";

				this.WriteBytesToFile(generatedFileName, generatedFileContent);
			}
		}

		protected virtual void WriteBytesToFile(string fileName, byte[] content)
		{
			if (!Directory.Exists(WorkingDirectory))
			{
				Directory.CreateDirectory(WorkingDirectory);
			}

			File.WriteAllBytes($"{WorkingDirectory}//{fileName}", content);
		}

		protected abstract byte[] GenerateFileContent(int contentLength);
	}
}
