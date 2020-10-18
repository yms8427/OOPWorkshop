using BilgeAdam.OOP.Workshop.Abstractions;
using System;
using System.Collections.Generic;

namespace BilgeAdam.OOP.Workshop.PublisherSubscriber
{
    public class Publisher
    {
        private List<Subscriber> subscribers;

        public Publisher()
        {
            subscribers = new List<Subscriber>();
        }
        public string Name { get; set; }
        public void Notify(IPublishable content)
        {
            foreach (var sub in subscribers)
            {
                sub.ContentNotified(content);
            }
        }

        internal void Add(Subscriber subscriber)
        {
            foreach (var sub in subscribers)
            {
                if (sub.Id == subscriber.Id)
                {
                    return;
                }
            }

            subscribers.Add(subscriber);
        }

        internal void Remove(Subscriber subscriber)
        {
            foreach (var sub in subscribers)
            {
                if (sub.Id == subscriber.Id)
                {
                    subscribers.Remove(sub);
                    break;
                }
            }
        }
    }
}
