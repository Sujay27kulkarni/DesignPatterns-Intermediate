using ObserverPattern.Observers.Abstractions;

namespace ObserverPattern.Observers.Implementations
{
    public class NotificationSubscriber : ISubscriber
    {
        public void Update(string news)
        {
            Console.WriteLine($"Mobile Notification received news update: {news}");
        }
    }
}
