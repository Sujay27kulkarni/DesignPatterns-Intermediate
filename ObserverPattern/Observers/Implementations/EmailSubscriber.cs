using ObserverPattern.Observers.Abstractions;

namespace ObserverPattern.Observers.Implementations
{
    public class EmailSubscriber : ISubscriber    
    {
        public void Update(string news)
        {
            Console.WriteLine($"Email received news update: {news}");
        }
    }
}
