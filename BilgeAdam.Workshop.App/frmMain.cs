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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public Publisher Publisher { get; set; }
        private void btnCreateAnnouncement_Click(object sender, EventArgs e)
        {
            //TODO: Validation
            var ann = new Announcement
            {
                Title = txtAnnTitle.Text,
                Content = txtAnnContent.Text,
                DueDate = dtpAnnLastDate.Value
            };
            
            Publisher.Notify(ann);
            
            txtAnnTitle.Clear();
            txtAnnContent.Clear();
            dtpAnnLastDate.Value = DateTime.Now.AddMinutes(1);
        }

        private void btnCreateNews_Click(object sender, EventArgs e)
        {
            var news = new News
            {
                Title = txtNewsTitle.Text,
                Content = txtNewsContent.Text
            };
            Publisher.Notify(news);
            txtNewsTitle.Clear();
            txtNewsContent.Clear();
        }

        private void btnCreateNotification_Click(object sender, EventArgs e)
        {
            var not = new Notification
            {
                Title = txtNotTitle.Text
            };
            Publisher.Notify(not);
            txtNotTitle.Clear();
        }

        private void btnSubscribe_Click(object sender, EventArgs e)
        {
            var frmSub = new frmSubscriber() 
            { 
                Publisher = this.Publisher 
            };
            frmSub.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Publisher = new Publisher()
            {
                Name = Guid.NewGuid().ToString()
            };
            lblIdentity.Text += Publisher.Name;
        }

        private void Buton1inTiklamaMethodu(object sender, EventArgs e)
        {
            MessageBox.Show("Tıklandım :D");
        }

        private void btnSubscribeNews_Click(object sender, EventArgs e)
        {
            var newsSubscriber = new frmNewsSubscriber
            {
                Publisher = Publisher
            };
            newsSubscriber.Show();
        }
    }
}
