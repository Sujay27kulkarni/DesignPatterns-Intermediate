using ObserverPattern.Observers.Abstractions;

namespace ObserverPattern.Observers.Implementations
{
    public class NewsPaperSubscriber : ISubscriber
    {
        public void Update(string news)
        {
           Console.WriteLine($"NewsPaper received news update: {news}");
        }
    }
}
