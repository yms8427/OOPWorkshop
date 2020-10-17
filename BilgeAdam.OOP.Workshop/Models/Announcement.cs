using BilgeAdam.OOP.Workshop.Abstractions;
using BilgeAdam.OOP.Workshop.Helpers;

namespace BilgeAdam.OOP.Workshop.Models
{
    public class Announcement : IPublishable
    {
        public Announcement()
        {
            Id = IdGenerator.Create<Announcement>();
        }
        public int Id { get; }

        public void Publish()
        {
        }
    }
}
