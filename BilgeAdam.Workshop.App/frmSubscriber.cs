using BilgeAdam.OOP.Workshop.Abstractions;
using BilgeAdam.OOP.Workshop.Models;
using BilgeAdam.OOP.Workshop.PublisherSubscriber;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgeAdam.Workshop.App
{
    public partial class frmSubscriber : Form
    {
        public frmSubscriber()
        {
            InitializeComponent();
            Subscriber = new Subscriber();
            Subscriber.OnContentNotified += Subscriber_OnContentNotified;
        }

        /// <summary>
        /// Bildirim gönderildiğinde tetiklenecek method
        /// </summary>
        /// <param name="content"></param>
        private void Subscriber_OnContentNotified(IPublishable content)
        {
            if (content is Announcement announcement)
            {
                lstAnnouncements.Items.Add(announcement);
                lstAnnouncements.DisplayMember = nameof(IPublishable.Title);
            }
            else if (content is News news)
            {
                lstNews.Items.Add(news);
                lstNews.DisplayMember = nameof(IPublishable.Title);
            }
            else
            {
                lstNotifications.Items.Add(content as Notification);
                lstNotifications.DisplayMember = nameof(IPublishable.Title);
            }
        }

        public Publisher Publisher { get; set; }
        public Subscriber Subscriber { get; set; }

        private void frmSubscriber_Load(object sender, EventArgs e)
        {
            Text += $" | Yayıncı Kimliği: {Publisher.Name}";
            Subscriber.Subscribe(Publisher);
            lblIdentity.Text += Subscriber.Id;
        }
    }
}
