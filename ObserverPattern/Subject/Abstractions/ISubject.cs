using ObserverPattern.Observers.Abstractions;

namespace ObserverPattern.Subject.Abstractions
{
    public interface ISubject
    {
        public void RegisterObserver(ISubscriber observer);
        public void DeRegisterObserver(ISubscriber observer);
        public void Notify();
    }
}
