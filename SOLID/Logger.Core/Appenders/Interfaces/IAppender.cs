namespace Logger.Core.Appenders.Interfaces
{
    using Enums;
    using Logger.Core.Formatting.Interfaces;
    using Models.Interfaces;

    public interface IAppender
    {
        ILayout Layout { get; }

        ReportLevel ReportLevel { get; }

        void AppendMessage(IMessage message);
    }
}
