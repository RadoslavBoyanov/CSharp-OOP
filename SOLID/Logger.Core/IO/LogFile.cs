using System.Text;
using Logger.Core.Exceptions;
using Logger.Core.IO.Interfaces;
using Logger.Core.Utilities;

namespace Logger.Core.IO
{
    public class LogFile: ILogFile
    {
        private string? name;
        private string? path;

        private readonly StringBuilder content;

        private LogFile()
        {
            this.content = new StringBuilder();
        }
        public LogFile(string name, string path)
        {
            this.Name = name;
            this.Path = path;
        }

        public string Path
        {
            get
            {
                return this.path!;
            }
            private set
            {
                if (!FileValidator.PathExist(value))
                {
                    throw new InvalidPathException();
                }

                this.path = System.IO.Path.GetFullPath(value);
            }
        }

        public string Name
        {
            get
            {
                return this.name!;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new EmptyFileNameException();
                }
                this.name = value;
            }

        }

        public string Content => this.content.ToString();

        public int Size => this.content.Length;
        public void Write(string text)
        {
            this.content.Append(text);
        }

        public void WriteLine(string text)
        {
            this.content.AppendLine(text);
        }

        //public void SaveContent()
        //{
        //    string previousContent = File.ReadAllText(this.Path);
        //    string futureContent = previousContent + Environment.NewLine + this.Content;
        //    File.WriteAllText(this.Path, futureContent);
        //    this.content.Clear();
        //}
    }
}
