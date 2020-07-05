using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCinema
{
    public partial class Form1 : Form
    {
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.topPanel_appTitle = new System.Windows.Forms.Label();
            this.sidePanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
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
            this.sidePanel.Size = new System.Drawing.Size(200, 638);
            this.sidePanel.TabIndex = 0;
            // 
            // sidePanel_aboutUsBtn
            // 
            this.sidePanel_aboutUsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanel_aboutUsBtn.Location = new System.Drawing.Point(0, 220);
            this.sidePanel_aboutUsBtn.Name = "sidePanel_aboutUsBtn";
            this.sidePanel_aboutUsBtn.Size = new System.Drawing.Size(200, 40);
            this.sidePanel_aboutUsBtn.TabIndex = 6;
            this.sidePanel_aboutUsBtn.Text = "About Us";
            this.sidePanel_aboutUsBtn.UseVisualStyleBackColor = true;
            // 
            // sidePanel_viewOnline
            // 
            this.sidePanel_viewOnline.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanel_viewOnline.Location = new System.Drawing.Point(0, 180);
            this.sidePanel_viewOnline.Name = "sidePanel_viewOnline";
            this.sidePanel_viewOnline.Size = new System.Drawing.Size(200, 40);
            this.sidePanel_viewOnline.TabIndex = 4;
            this.sidePanel_viewOnline.Text = "View Online";
            this.sidePanel_viewOnline.UseVisualStyleBackColor = true;
            // 
            // sidePanel_addMovieBtn
            // 
            this.sidePanel_addMovieBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanel_addMovieBtn.Location = new System.Drawing.Point(0, 140);
            this.sidePanel_addMovieBtn.Name = "sidePanel_addMovieBtn";
            this.sidePanel_addMovieBtn.Size = new System.Drawing.Size(200, 40);
            this.sidePanel_addMovieBtn.TabIndex = 3;
            this.sidePanel_addMovieBtn.Text = "Add Movie";
            this.sidePanel_addMovieBtn.UseVisualStyleBackColor = true;
            // 
            // sidePanel_viewMoviesBtn
            // 
            this.sidePanel_viewMoviesBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanel_viewMoviesBtn.Location = new System.Drawing.Point(0, 100);
            this.sidePanel_viewMoviesBtn.Name = "sidePanel_viewMoviesBtn";
            this.sidePanel_viewMoviesBtn.Size = new System.Drawing.Size(200, 40);
            this.sidePanel_viewMoviesBtn.TabIndex = 1;
            this.sidePanel_viewMoviesBtn.Text = "View Movies";
            this.sidePanel_viewMoviesBtn.UseVisualStyleBackColor = true;
            // 
            // sidePanel_logo
            // 
            this.sidePanel_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanel_logo.Location = new System.Drawing.Point(0, 0);
            this.sidePanel_logo.Name = "sidePanel_logo";
            this.sidePanel_logo.Size = new System.Drawing.Size(200, 100);
            this.sidePanel_logo.TabIndex = 0;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.topPanel.Controls.Add(this.topPanel_appTitle);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(200, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(674, 70);
            this.topPanel.TabIndex = 1;
            // 
            // topPanel_appTitle
            // 
            this.topPanel_appTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.topPanel_appTitle.AutoSize = true;
            this.topPanel_appTitle.ForeColor = System.Drawing.Color.White;
            this.topPanel_appTitle.Location = new System.Drawing.Point(300, 26);
            this.topPanel_appTitle.Name = "topPanel_appTitle";
            this.topPanel_appTitle.Size = new System.Drawing.Size(128, 15);
            this.topPanel_appTitle.TabIndex = 0;
            this.topPanel_appTitle.Text = "My Cinema by W60113";
            this.topPanel_appTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(874, 638);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.sidePanel);
            this.Name = "Form1";
            this.sidePanel.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
