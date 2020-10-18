using BilgeAdam.OOP.Workshop.Abstractions;
using System;

namespace BilgeAdam.OOP.Workshop.PublisherSubscriber
{
    public class Subscriber
    {
        public Subscriber()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }

        internal void ContentNotified(IPublishable publishable)
        {
            OnContentNotified?.Invoke(publishable);
        }

        public event SubscriberHandler OnContentNotified;
        public delegate void SubscriberHandler(IPublishable content);

        public void Subscribe(Publisher publisher)
        {
            publisher.Add(this);
        }

        public void Unsubscribe(Publisher publisher)
        {
            publisher.Remove(this);
        }
    }


}
