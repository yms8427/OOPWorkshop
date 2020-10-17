namespace BilgeAdam.Workshop.App
{
    partial class frmSubscriber
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstAnnouncements = new System.Windows.Forms.ListBox();
            this.lstNews = new System.Windows.Forms.ListBox();
            this.lstNotifications = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstAnnouncements
            // 
            this.lstAnnouncements.FormattingEnabled = true;
            this.lstAnnouncements.Location = new System.Drawing.Point(12, 25);
            this.lstAnnouncements.Name = "lstAnnouncements";
            this.lstAnnouncements.Size = new System.Drawing.Size(183, 186);
            this.lstAnnouncements.TabIndex = 0;
            // 
            // lstNews
            // 
            this.lstNews.FormattingEnabled = true;
            this.lstNews.Location = new System.Drawing.Point(201, 25);
            this.lstNews.Name = "lstNews";
            this.lstNews.Size = new System.Drawing.Size(183, 186);
            this.lstNews.TabIndex = 0;
            // 
            // lstNotifications
            // 
            this.lstNotifications.FormattingEnabled = true;
            this.lstNotifications.Location = new System.Drawing.Point(390, 25);
            this.lstNotifications.Name = "lstNotifications";
            this.lstNotifications.Size = new System.Drawing.Size(183, 186);
            this.lstNotifications.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Duyurular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Haberler";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(457, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Bildirimler";
            // 
            // frmSubscriber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 222);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstNotifications);
            this.Controls.Add(this.lstNews);
            this.Controls.Add(this.lstAnnouncements);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSubscriber";
            this.Text = "Abone";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstAnnouncements;
        private System.Windows.Forms.ListBox lstNews;
        private System.Windows.Forms.ListBox lstNotifications;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}