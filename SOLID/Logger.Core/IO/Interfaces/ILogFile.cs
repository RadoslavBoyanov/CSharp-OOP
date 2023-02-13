namespace Logger.Core.IO.Interfaces
{
    public interface ILogFile
    {
        string Path { get; }
        string Name { get; }
        string Content { get; }
        int Size { get; }
        void Write(string text);
        void WriteLine(string text);
    }
}
