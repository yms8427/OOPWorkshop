using BilgeAdam.OOP.Workshop.Abstractions;
using BilgeAdam.OOP.Workshop.Helpers;
using System;

namespace BilgeAdam.OOP.Workshop.Models
{
    public class Announcement : IPublishable
    {
        public Announcement()
        {
            Id = IdGenerator.Create<Announcement>();
        }
        public int Id { get; }

        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime DueDate { get; set; }
    }
}
