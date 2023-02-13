namespace Logger.ConsoleApp.Factories.Interfaces
{
    using Logger.Core.Formatting.Interfaces;

    public interface ILayoutFactory
    {
        ILayout CreateLayout(string type);
    }
}