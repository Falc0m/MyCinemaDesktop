using MyCinema2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCinema
{
    public partial class Form1 : Form
    {

        public static Form activeForm = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.sidePanel = new System.Windows.Forms.Panel();
            this.sidePanel_aboutUsBtn = new System.Windows.Forms.Button();
            this.sidePanel_viewOnline = new System.Windows.Forms.Button();
            this.sidePanel_addMovieBtn = new System.Windows.Forms.Button();
            this.sidePanel_viewMoviesBtn = new System.Windows.Forms.Button();
            this.sidePanel_logo = new System.Windows.Forms.Panel();
            this.app_title = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.sidePanel.SuspendLayout();
            this.sidePanel_logo.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.AutoScroll = true;
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.sidePanel.Controls.Add(this.sidePanel_aboutUsBtn);
            this.sidePanel.Controls.Add(this.sidePanel_viewOnline);
            this.sidePanel.Controls.Add(this.sidePanel_addMovieBtn);
            this.sidePanel.Controls.Add(this.sidePanel_viewMoviesBtn);
            this.sidePanel.Controls.Add(this.sidePanel_logo);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.ForeColor = System.Drawing.Color.White;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(200, 561);
            this.sidePanel.TabIndex = 0;
            // 
            // sidePanel_aboutUsBtn
            // 
            this.sidePanel_aboutUsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanel_aboutUsBtn.FlatAppearance.BorderSize = 0;
            this.sidePanel_aboutUsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sidePanel_aboutUsBtn.ForeColor = System.Drawing.Color.LightGray;
            this.sidePanel_aboutUsBtn.Location = new System.Drawing.Point(0, 220);
            this.sidePanel_aboutUsBtn.Name = "sidePanel_aboutUsBtn";
            this.sidePanel_aboutUsBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.sidePanel_aboutUsBtn.Size = new System.Drawing.Size(200, 40);
            this.sidePanel_aboutUsBtn.TabIndex = 6;
            this.sidePanel_aboutUsBtn.Text = "About Us";
            this.sidePanel_aboutUsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sidePanel_aboutUsBtn.UseVisualStyleBackColor = true;
            this.sidePanel_aboutUsBtn.Click += new System.EventHandler(this.sidePanel_aboutUsBtn_Click);
            // 
            // sidePanel_viewOnline
            // 
            this.sidePanel_viewOnline.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanel_viewOnline.FlatAppearance.BorderSize = 0;
            this.sidePanel_viewOnline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sidePanel_viewOnline.ForeColor = System.Drawing.Color.LightGray;
            this.sidePanel_viewOnline.Location = new System.Drawing.Point(0, 180);
            this.sidePanel_viewOnline.Name = "sidePanel_viewOnline";
            this.sidePanel_viewOnline.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.sidePanel_viewOnline.Size = new System.Drawing.Size(200, 40);
            this.sidePanel_viewOnline.TabIndex = 4;
            this.sidePanel_viewOnline.Text = "View Online";
            this.sidePanel_viewOnline.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sidePanel_viewOnline.UseVisualStyleBackColor = true;
            this.sidePanel_viewOnline.Click += new System.EventHandler(this.sidePanel_viewOnline_Click);
            // 
            // sidePanel_addMovieBtn
            // 
            this.sidePanel_addMovieBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanel_addMovieBtn.FlatAppearance.BorderSize = 0;
            this.sidePanel_addMovieBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sidePanel_addMovieBtn.ForeColor = System.Drawing.Color.LightGray;
            this.sidePanel_addMovieBtn.Location = new System.Drawing.Point(0, 140);
            this.sidePanel_addMovieBtn.Name = "sidePanel_addMovieBtn";
            this.sidePanel_addMovieBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.sidePanel_addMovieBtn.Size = new System.Drawing.Size(200, 40);
            this.sidePanel_addMovieBtn.TabIndex = 3;
            this.sidePanel_addMovieBtn.Text = "Add Movie";
            this.sidePanel_addMovieBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sidePanel_addMovieBtn.UseVisualStyleBackColor = true;
            this.sidePanel_addMovieBtn.Click += new System.EventHandler(this.sidePanel_addMovieBtn_Click);
            // 
            // sidePanel_viewMoviesBtn
            // 
            this.sidePanel_viewMoviesBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanel_viewMoviesBtn.FlatAppearance.BorderSize = 0;
            this.sidePanel_viewMoviesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sidePanel_viewMoviesBtn.ForeColor = System.Drawing.Color.LightGray;
            this.sidePanel_viewMoviesBtn.Location = new System.Drawing.Point(0, 100);
            this.sidePanel_viewMoviesBtn.Name = "sidePanel_viewMoviesBtn";
            this.sidePanel_viewMoviesBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.sidePanel_viewMoviesBtn.Size = new System.Drawing.Size(200, 40);
            this.sidePanel_viewMoviesBtn.TabIndex = 1;
            this.sidePanel_viewMoviesBtn.Text = "View Movies";
            this.sidePanel_viewMoviesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sidePanel_viewMoviesBtn.UseVisualStyleBackColor = true;
            this.sidePanel_viewMoviesBtn.Click += new System.EventHandler(this.sidePanel_viewMoviesBtn_Click);
            // 
            // sidePanel_logo
            // 
            this.sidePanel_logo.Controls.Add(this.app_title);
            this.sidePanel_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanel_logo.Location = new System.Drawing.Point(0, 0);
            this.sidePanel_logo.Name = "sidePanel_logo";
            this.sidePanel_logo.Size = new System.Drawing.Size(200, 100);
            this.sidePanel_logo.TabIndex = 0;
            // 
            // app_title
            // 
            this.app_title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.app_title.Location = new System.Drawing.Point(0, 0);
            this.app_title.Name = "app_title";
            this.app_title.Size = new System.Drawing.Size(200, 100);
            this.app_title.TabIndex = 0;
            this.app_title.Text = "My Cinema by W60113";
            this.app_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(200, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(734, 561);
            this.mainPanel.TabIndex = 2;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.sidePanel);
            this.Name = "Form1";
            this.Text = "My Cinema";
            this.sidePanel.ResumeLayout(false);
            this.sidePanel_logo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void sidePanel_viewMoviesBtn_Click(object sender, EventArgs e)
        {
            setMainForm(new Form2(mainPanel));
        }

        public void setMainForm(Form passedForm)
        {

            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = passedForm;

            passedForm.TopLevel = false;
            passedForm.FormBorderStyle = FormBorderStyle.None;
            passedForm.Dock = DockStyle.Fill;

            mainPanel.Controls.Add(passedForm);
            mainPanel.Tag = passedForm;

            passedForm.Show();

        }

        private void sidePanel_addMovieBtn_Click(object sender, EventArgs e)
        {
            setMainForm(new AddMovieForm());
        }

        private void sidePanel_viewOnline_Click(object sender, EventArgs e)
        {
            Process.Start("http://13.53.159.1:8080");
        }

        private void sidePanel_aboutUsBtn_Click(object sender, EventArgs e)
        {
            setMainForm(new AboutUsForm());
        }
    }
}
