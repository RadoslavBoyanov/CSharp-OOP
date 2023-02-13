
using Logger.Core.Enums;

namespace Logger.Core.Models.Interfaces
{
    public interface IMessage
    {
        public string MessageText { get;  }
        public string DateTime { get;  }
        public ReportLevel ReportLevel { get; }
    }
}
