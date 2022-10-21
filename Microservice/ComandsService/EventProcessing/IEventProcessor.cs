namespace ComandsService.EventProcessing
{
    public interface IEventProcessor
    {
        void ProcessEvent(string message);
    }
}
