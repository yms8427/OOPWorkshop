namespace BilgeAdam.Workshop.App
{
    partial class frmMain
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
            this.btnCreateAnnouncement = new System.Windows.Forms.Button();
            this.btnCreateNews = new System.Windows.Forms.Button();
            this.btnCreateNotification = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dtpAnnLastDate = new System.Windows.Forms.DateTimePicker();
            this.txtAnnContent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAnnTitle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtNewsContent = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNewsTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtNotTitle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSubscribe = new System.Windows.Forms.Button();
            this.lblIdentity = new System.Windows.Forms.Label();
            this.btnSubscribeNews = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateAnnouncement
            // 
            this.btnCreateAnnouncement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateAnnouncement.Location = new System.Drawing.Point(234, 171);
            this.btnCreateAnnouncement.Name = "btnCreateAnnouncement";
            this.btnCreateAnnouncement.Size = new System.Drawing.Size(89, 29);
            this.btnCreateAnnouncement.TabIndex = 0;
            this.btnCreateAnnouncement.Text = "Oluştur";
            this.btnCreateAnnouncement.UseVisualStyleBackColor = true;
            this.btnCreateAnnouncement.Click += new System.EventHandler(this.btnCreateAnnouncement_Click);
            // 
            // btnCreateNews
            // 
            this.btnCreateNews.Location = new System.Drawing.Point(222, 158);
            this.btnCreateNews.Name = "btnCreateNews";
            this.btnCreateNews.Size = new System.Drawing.Size(89, 29);
            this.btnCreateNews.TabIndex = 0;
            this.btnCreateNews.Text = "Oluştur";
            this.btnCreateNews.UseVisualStyleBackColor = true;
            this.btnCreateNews.Click += new System.EventHandler(this.btnCreateNews_Click);
            // 
            // btnCreateNotification
            // 
            this.btnCreateNotification.Location = new System.Drawing.Point(222, 92);
            this.btnCreateNotification.Name = "btnCreateNotification";
            this.btnCreateNotification.Size = new System.Drawing.Size(89, 29);
            this.btnCreateNotification.TabIndex = 0;
            this.btnCreateNotification.Text = "Oluştur";
            this.btnCreateNotification.UseVisualStyleBackColor = true;
            this.btnCreateNotification.Click += new System.EventHandler(this.btnCreateNotification_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(357, 302);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dtpAnnLastDate);
            this.tabPage1.Controls.Add(this.txtAnnContent);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtAnnTitle);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnCreateAnnouncement);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(349, 249);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Duyuru";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dtpAnnLastDate
            // 
            this.dtpAnnLastDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpAnnLastDate.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpAnnLastDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAnnLastDate.Location = new System.Drawing.Point(67, 131);
            this.dtpAnnLastDate.Name = "dtpAnnLastDate";
            this.dtpAnnLastDate.Size = new System.Drawing.Size(256, 20);
            this.dtpAnnLastDate.TabIndex = 3;
            // 
            // txtAnnContent
            // 
            this.txtAnnContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAnnContent.Location = new System.Drawing.Point(67, 32);
            this.txtAnnContent.Multiline = true;
            this.txtAnnContent.Name = "txtAnnContent";
            this.txtAnnContent.Size = new System.Drawing.Size(256, 93);
            this.txtAnnContent.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "İçerik";
            // 
            // txtAnnTitle
            // 
            this.txtAnnTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAnnTitle.Location = new System.Drawing.Point(67, 6);
            this.txtAnnTitle.Name = "txtAnnTitle";
            this.txtAnnTitle.Size = new System.Drawing.Size(256, 20);
            this.txtAnnTitle.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Bitiş Tarihi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Başlık";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtNewsContent);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtNewsTitle);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.btnCreateNews);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(349, 276);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Haber";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtNewsContent
            // 
            this.txtNewsContent.Location = new System.Drawing.Point(65, 50);
            this.txtNewsContent.Multiline = true;
            this.txtNewsContent.Name = "txtNewsContent";
            this.txtNewsContent.Size = new System.Drawing.Size(246, 93);
            this.txtNewsContent.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "İçerik";
            // 
            // txtNewsTitle
            // 
            this.txtNewsTitle.Location = new System.Drawing.Point(65, 24);
            this.txtNewsTitle.Name = "txtNewsTitle";
            this.txtNewsTitle.Size = new System.Drawing.Size(246, 20);
            this.txtNewsTitle.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Başlık";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtNotTitle);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.btnCreateNotification);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(349, 292);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Bildirim";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtNotTitle
            // 
            this.txtNotTitle.Location = new System.Drawing.Point(65, 66);
            this.txtNotTitle.Name = "txtNotTitle";
            this.txtNotTitle.Size = new System.Drawing.Size(246, 20);
            this.txtNotTitle.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Başlık";
            // 
            // btnSubscribe
            // 
            this.btnSubscribe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubscribe.Location = new System.Drawing.Point(272, 368);
            this.btnSubscribe.Name = "btnSubscribe";
            this.btnSubscribe.Size = new System.Drawing.Size(97, 30);
            this.btnSubscribe.TabIndex = 2;
            this.btnSubscribe.Text = "Abone Ol";
            this.btnSubscribe.UseVisualStyleBackColor = true;
            this.btnSubscribe.Click += new System.EventHandler(this.btnSubscribe_Click);
            // 
            // lblIdentity
            // 
            this.lblIdentity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblIdentity.AutoSize = true;
            this.lblIdentity.Location = new System.Drawing.Point(13, 329);
            this.lblIdentity.Name = "lblIdentity";
            this.lblIdentity.Size = new System.Drawing.Size(82, 13);
            this.lblIdentity.TabIndex = 3;
            this.lblIdentity.Text = "Yayıncı Kimliği : ";
            // 
            // btnSubscribeNews
            // 
            this.btnSubscribeNews.Location = new System.Drawing.Point(145, 368);
            this.btnSubscribeNews.Name = "btnSubscribeNews";
            this.btnSubscribeNews.Size = new System.Drawing.Size(121, 30);
            this.btnSubscribeNews.TabIndex = 4;
            this.btnSubscribeNews.Text = "Haberlere Abone Ol";
            this.btnSubscribeNews.UseVisualStyleBackColor = true;
            this.btnSubscribeNews.Click += new System.EventHandler(this.btnSubscribeNews_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 410);
            this.Controls.Add(this.btnSubscribeNews);
            this.Controls.Add(this.lblIdentity);
            this.Controls.Add(this.btnSubscribe);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yayın Uygulaması";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateAnnouncement;
        private System.Windows.Forms.Button btnCreateNews;
        private System.Windows.Forms.Button btnCreateNotification;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DateTimePicker dtpAnnLastDate;
        private System.Windows.Forms.TextBox txtAnnContent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAnnTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNewsContent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNewsTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNotTitle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSubscribe;
        private System.Windows.Forms.Label lblIdentity;
        private System.Windows.Forms.Button btnSubscribeNews;
    }
}

