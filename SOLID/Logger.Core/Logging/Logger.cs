using Logger.Core.Appenders.Interfaces;
using Logger.Core.Enums;
using Logger.Core.Logging.Interfaces;
using Logger.Core.Models;
using Logger.Core.Models.Interfaces;

namespace Logger.Core.Logging
{
    public class Logger : ILogger
    {
        private readonly ICollection<IAppender> appenders;
        public Logger(params ICollection<IAppender>[] appenders)
        {
            this.appenders = appenders; 
        }
        public void Info(string dateTime, string message)
        {
            this.Append(dateTime, message, ReportLevel.Info);
        }

        public void Warn(string dateTime, string message)
        {
            this.Append(dateTime, message, ReportLevel.Warning);
        }

        public void Error(string dateTime, string message)
        {
            this.Append(dateTime, message, ReportLevel.Error);
        }

        public void Critical(string dateTime, string message)
        {
            this.Append(dateTime, message, ReportLevel.Critical);
        }

        public void Fatal(string dateTime, string message)
        {
            this.Append(dateTime, message, ReportLevel.Fatal);
        }

        private void Append(string dateTime, string messageText, ReportLevel reportLevel)
        {
            IMessage message = new Message(messageText, dateTime, reportLevel);
            foreach (IAppender appender in this.appenders)
            {
                if (message.ReportLevel >= appender.ReportLevel)
                {
                    appender.AppendMessage(message);
                }
            }
        }
    }
}
