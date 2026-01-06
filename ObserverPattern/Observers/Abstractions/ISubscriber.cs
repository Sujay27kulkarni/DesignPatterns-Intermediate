namespace ObserverPattern.Observers.Abstractions
{
    public interface ISubscriber
    {
        public void Update(string news);
    }
}
