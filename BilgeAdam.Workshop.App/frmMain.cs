using BilgeAdam.OOP.Workshop.Models;
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

        private void btnCreateAnnouncement_Click(object sender, EventArgs e)
        {
            var ann = new Announcement();
        }

        private void btnCreateNews_Click(object sender, EventArgs e)
        {
            var news = new News();
        }

        private void btnCreateNotification_Click(object sender, EventArgs e)
        {
            var not = new Notification();
        }

        private void btnSubscribe_Click(object sender, EventArgs e)
        {
            var frmSub = new frmSubscriber();
            frmSub.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
