using BilgeAdam.OOP.Workshop.Abstractions;
using BilgeAdam.OOP.Workshop.Helpers;

namespace BilgeAdam.OOP.Workshop.Models
{
    public class Notification : IPublishable
    {
        public Notification()
        {
            Id = IdGenerator.Create<Notification>();
        }
        public int Id { get; }

        public void Publish()
        {
        }
    }
}
