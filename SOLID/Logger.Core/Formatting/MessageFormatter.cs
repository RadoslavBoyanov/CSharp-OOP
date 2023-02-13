using Logger.Core.Formatting.Interfaces;
using Logger.Core.Models.Interfaces;

namespace Logger.Core.Formatting
{
    public class MessageFormatter : IFormatter
    {
        public string Format(IMessage message, ILayout layout)
        {
            return string.Format(layout.Format, message.DateTime, message.ReportLevel.ToString(), message.MessageText);
        }
    }
}
