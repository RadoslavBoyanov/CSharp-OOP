using Logger.Core.Models.Interfaces;

namespace Logger.Core.Formatting.Interfaces
{
    public interface IFormatter
    {
        string Format(IMessage message, ILayout layout);
    }
}
