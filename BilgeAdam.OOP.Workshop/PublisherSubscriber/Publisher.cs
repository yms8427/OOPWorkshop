using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.OOP.Workshop.PublisherSubscriber
{
    class Publisher
    {
        public List<Subscriber> Subscribers { get; set; }
        public void Notify()
        {
            foreach (var sub in Subscribers)
            {
              //TODO : broadcast  
            }
        }
    }

    class Subscriber
    {
        public Subscriber()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }

        public void Subscribe(Publisher publisher)
        {
            //Event raised
        }

        public void Unsubscribe(Publisher publisher)
        {
            //remove
        }
    }
}
