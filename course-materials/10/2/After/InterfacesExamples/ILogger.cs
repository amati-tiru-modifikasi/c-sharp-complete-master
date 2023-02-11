namespace InterfacesExamples
{
    public interface ILogger
    {
        bool IsEnabled { get; set; }
        void Log();
    }
}