namespace MyCinema2
{
    partial class AboutUsForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.aboutUs_title = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.aboutUs_title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 35);
            this.panel1.TabIndex = 0;
            // 
            // aboutUs_title
            // 
            this.aboutUs_title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aboutUs_title.ForeColor = System.Drawing.Color.White;
            this.aboutUs_title.Location = new System.Drawing.Point(0, 0);
            this.aboutUs_title.Name = "aboutUs_title";
            this.aboutUs_title.Size = new System.Drawing.Size(615, 35);
            this.aboutUs_title.TabIndex = 0;
            this.aboutUs_title.Text = "About Us";
            this.aboutUs_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AboutUsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(615, 400);
            this.Controls.Add(this.panel1);
            this.Name = "AboutUsForm";
            this.Text = "My Cinema";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label aboutUs_title;
    }
}