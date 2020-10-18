using BilgeAdam.OOP.Workshop.Abstractions;
using BilgeAdam.OOP.Workshop.Helpers;

namespace BilgeAdam.OOP.Workshop.Models
{
    public class News : IPublishable
    {
        public News()
        {
            Id = IdGenerator.Create<News>();
        }
        public int Id { get; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
