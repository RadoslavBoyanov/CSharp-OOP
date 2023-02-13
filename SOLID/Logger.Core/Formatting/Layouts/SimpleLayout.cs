using Logger.Core.Formatting.Interfaces;

namespace Logger.Core.Formatting.Layouts
{
    public class SimpleLayout : ILayout
    {
        public string Format => "{0} - {1} - {2}";
    }
}
