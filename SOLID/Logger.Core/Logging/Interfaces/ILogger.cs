namespace Logger.Core.Logging.Interfaces
{
    public interface ILogger
    {
        void Info(string daytime, string message);
        void Warn(string daytime, string message);
        void Error(string daytime, string message);

        void Critical(string daytime, string message);
        void Fatal(string daytime, string message);
    }
}
