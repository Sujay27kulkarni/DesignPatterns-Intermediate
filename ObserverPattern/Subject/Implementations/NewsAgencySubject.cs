using ObserverPattern.Observers.Abstractions;
using ObserverPattern.Observers.Implementations;
using ObserverPattern.Subject.Abstractions;
using System.Collections.Generic;

namespace ObserverPattern.Subject.Implementations
{
    public class NewsAgencySubject : ISubject
    {
        List<ISubscriber> _subscribers = new List<ISubscriber>();
        public IReadOnlyList<ISubscriber> subscribers => _subscribers.AsReadOnly();


        //This is the state in the pattrn that the subject updates when something happens
        public string _news { get; set; }        

        public void DeRegisterObserver(ISubscriber observer)
        {
            var type = observer.GetType(); 
            _subscribers.RemoveAll(s => s.GetType() == type);
        }

        public void RegisterObserver(ISubscriber observer)
        {
            if (!_subscribers.Contains(observer)) 
                _subscribers.Add(observer);
        }

        public void Notify()
        {
            foreach (var subscriber in _subscribers)
            {
                subscriber.Update(_news);
            }
        }

        public void ReleaseNews(string news)
        {
            _news = news;
            Notify();
        }


    }
}
