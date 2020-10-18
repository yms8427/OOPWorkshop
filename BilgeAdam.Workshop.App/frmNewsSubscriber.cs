using BilgeAdam.OOP.Workshop.Abstractions;
using BilgeAdam.OOP.Workshop.Models;
using BilgeAdam.OOP.Workshop.PublisherSubscriber;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace BilgeAdam.Workshop.App
{
    public partial class frmNewsSubscriber : Form
    {
        public frmNewsSubscriber()
        {
            InitializeComponent();
            News = new BindingList<News>();
            dgvNews.DataSource = News;

            Subscriber = new Subscriber();
            Subscriber.OnContentNotified += Subscriber_OnContentNotified;
        }
        public BindingList<News> News { get; set; }
        private void Subscriber_OnContentNotified(IPublishable content)
        {
            if (content is News news)
            {
                News.Add(news);
            }
        }

        public Publisher Publisher { get; set; }
        public Subscriber Subscriber { get; set; }
        private void frmNewsSubscriber_Load(object sender, EventArgs e)
        {
            lblIdentity.Text += Subscriber.Id;
            Text += $" | Yayıncı Kodu : {Publisher.Name}";
            Subscriber.Subscribe(Publisher);
        }
    }
}
