using MyCinema;

namespace MyCinema2
{
    partial class AddMovieForm
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
            this.addMovie_label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addMovie_descriptionTxt = new System.Windows.Forms.RichTextBox();
            this.addMovie_submitBtn = new System.Windows.Forms.Button();
            this.addMovie_categoryCmbBox = new System.Windows.Forms.ComboBox();
            this.addMovie_datePicker = new System.Windows.Forms.DateTimePicker();
            this.addMovie_premiereDateLabel = new System.Windows.Forms.Label();
            this.addMovie_descriptionLabel = new System.Windows.Forms.Label();
            this.addMovie_categoryLabel = new System.Windows.Forms.Label();
            this.addMovie_titleTxt = new System.Windows.Forms.TextBox();
            this.addMovie_titleLabel = new System.Windows.Forms.Label();
            this.addMovie_idTxt = new System.Windows.Forms.TextBox();
            this.addMovie_idLabel = new System.Windows.Forms.Label();
            this.addMovie_ratingLabel = new System.Windows.Forms.Label();
            this.addMovie_ratingCmbBox = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addMovie_label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 35);
            this.panel1.TabIndex = 0;
            // 
            // addMovie_label
            // 
            this.addMovie_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.addMovie_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addMovie_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMovie_label.ForeColor = System.Drawing.Color.White;
            this.addMovie_label.Location = new System.Drawing.Point(0, 0);
            this.addMovie_label.Name = "addMovie_label";
            this.addMovie_label.Size = new System.Drawing.Size(615, 35);
            this.addMovie_label.TabIndex = 0;
            this.addMovie_label.Text = "Add/Edit Movie";
            this.addMovie_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.addMovie_descriptionTxt);
            this.panel2.Controls.Add(this.addMovie_submitBtn);
            this.panel2.Controls.Add(this.addMovie_ratingCmbBox);
            this.panel2.Controls.Add(this.addMovie_categoryCmbBox);
            this.panel2.Controls.Add(this.addMovie_datePicker);
            this.panel2.Controls.Add(this.addMovie_premiereDateLabel);
            this.panel2.Controls.Add(this.addMovie_ratingLabel);
            this.panel2.Controls.Add(this.addMovie_descriptionLabel);
            this.panel2.Controls.Add(this.addMovie_categoryLabel);
            this.panel2.Controls.Add(this.addMovie_titleTxt);
            this.panel2.Controls.Add(this.addMovie_titleLabel);
            this.panel2.Controls.Add(this.addMovie_idTxt);
            this.panel2.Controls.Add(this.addMovie_idLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(615, 365);
            this.panel2.TabIndex = 1;
            // 
            // addMovie_descriptionTxt
            // 
            this.addMovie_descriptionTxt.Location = new System.Drawing.Point(247, 171);
            this.addMovie_descriptionTxt.Name = "addMovie_descriptionTxt";
            this.addMovie_descriptionTxt.Size = new System.Drawing.Size(230, 84);
            this.addMovie_descriptionTxt.TabIndex = 6;
            this.addMovie_descriptionTxt.Text = "";
            // 
            // addMovie_submitBtn
            // 
            this.addMovie_submitBtn.Location = new System.Drawing.Point(247, 316);
            this.addMovie_submitBtn.Name = "addMovie_submitBtn";
            this.addMovie_submitBtn.Size = new System.Drawing.Size(75, 23);
            this.addMovie_submitBtn.TabIndex = 5;
            this.addMovie_submitBtn.Text = "Submit";
            this.addMovie_submitBtn.UseVisualStyleBackColor = true;
            this.addMovie_submitBtn.Click += new System.EventHandler(this.addMovie_submitBtn_Click);
            // 
            // addMovie_categoryCmbBox
            // 
            this.addMovie_categoryCmbBox.FormattingEnabled = true;
            this.addMovie_categoryCmbBox.Items.AddRange(new object[] {
            "Action",
            "Comedy",
            "Drama",
            "Western",
            "Criminal"});
            this.addMovie_categoryCmbBox.Location = new System.Drawing.Point(247, 91);
            this.addMovie_categoryCmbBox.Name = "addMovie_categoryCmbBox";
            this.addMovie_categoryCmbBox.Size = new System.Drawing.Size(230, 21);
            this.addMovie_categoryCmbBox.TabIndex = 4;
            // 
            // addMovie_datePicker
            // 
            this.addMovie_datePicker.Location = new System.Drawing.Point(247, 272);
            this.addMovie_datePicker.Name = "addMovie_datePicker";
            this.addMovie_datePicker.Size = new System.Drawing.Size(230, 20);
            this.addMovie_datePicker.TabIndex = 3;
            // 
            // addMovie_premiereDateLabel
            // 
            this.addMovie_premiereDateLabel.AutoSize = true;
            this.addMovie_premiereDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMovie_premiereDateLabel.ForeColor = System.Drawing.Color.White;
            this.addMovie_premiereDateLabel.Location = new System.Drawing.Point(112, 272);
            this.addMovie_premiereDateLabel.Name = "addMovie_premiereDateLabel";
            this.addMovie_premiereDateLabel.Size = new System.Drawing.Size(111, 20);
            this.addMovie_premiereDateLabel.TabIndex = 1;
            this.addMovie_premiereDateLabel.Text = "Premiere Date";
            // 
            // addMovie_descriptionLabel
            // 
            this.addMovie_descriptionLabel.AutoSize = true;
            this.addMovie_descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMovie_descriptionLabel.ForeColor = System.Drawing.Color.White;
            this.addMovie_descriptionLabel.Location = new System.Drawing.Point(134, 202);
            this.addMovie_descriptionLabel.Name = "addMovie_descriptionLabel";
            this.addMovie_descriptionLabel.Size = new System.Drawing.Size(89, 20);
            this.addMovie_descriptionLabel.TabIndex = 1;
            this.addMovie_descriptionLabel.Text = "Description";
            // 
            // addMovie_categoryLabel
            // 
            this.addMovie_categoryLabel.AutoSize = true;
            this.addMovie_categoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMovie_categoryLabel.ForeColor = System.Drawing.Color.White;
            this.addMovie_categoryLabel.Location = new System.Drawing.Point(150, 89);
            this.addMovie_categoryLabel.Name = "addMovie_categoryLabel";
            this.addMovie_categoryLabel.Size = new System.Drawing.Size(73, 20);
            this.addMovie_categoryLabel.TabIndex = 1;
            this.addMovie_categoryLabel.Text = "Category";
            // 
            // addMovie_titleTxt
            // 
            this.addMovie_titleTxt.Location = new System.Drawing.Point(247, 54);
            this.addMovie_titleTxt.Name = "addMovie_titleTxt";
            this.addMovie_titleTxt.Size = new System.Drawing.Size(230, 20);
            this.addMovie_titleTxt.TabIndex = 2;
            // 
            // addMovie_titleLabel
            // 
            this.addMovie_titleLabel.AutoSize = true;
            this.addMovie_titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMovie_titleLabel.ForeColor = System.Drawing.Color.White;
            this.addMovie_titleLabel.Location = new System.Drawing.Point(185, 54);
            this.addMovie_titleLabel.Name = "addMovie_titleLabel";
            this.addMovie_titleLabel.Size = new System.Drawing.Size(38, 20);
            this.addMovie_titleLabel.TabIndex = 1;
            this.addMovie_titleLabel.Text = "Title";
            // 
            // addMovie_idTxt
            // 
            this.addMovie_idTxt.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.addMovie_idTxt.Enabled = false;
            this.addMovie_idTxt.Location = new System.Drawing.Point(247, 18);
            this.addMovie_idTxt.Name = "addMovie_idTxt";
            this.addMovie_idTxt.Size = new System.Drawing.Size(230, 20);
            this.addMovie_idTxt.TabIndex = 2;
            // 
            // addMovie_idLabel
            // 
            this.addMovie_idLabel.AutoSize = true;
            this.addMovie_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMovie_idLabel.ForeColor = System.Drawing.Color.White;
            this.addMovie_idLabel.Location = new System.Drawing.Point(200, 18);
            this.addMovie_idLabel.Name = "addMovie_idLabel";
            this.addMovie_idLabel.Size = new System.Drawing.Size(23, 20);
            this.addMovie_idLabel.TabIndex = 1;
            this.addMovie_idLabel.Text = "Id";
            // 
            // addMovie_ratingLabel
            // 
            this.addMovie_ratingLabel.AutoSize = true;
            this.addMovie_ratingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMovie_ratingLabel.ForeColor = System.Drawing.Color.White;
            this.addMovie_ratingLabel.Location = new System.Drawing.Point(167, 127);
            this.addMovie_ratingLabel.Name = "addMovie_ratingLabel";
            this.addMovie_ratingLabel.Size = new System.Drawing.Size(56, 20);
            this.addMovie_ratingLabel.TabIndex = 1;
            this.addMovie_ratingLabel.Text = "Rating";
            // 
            // addMovie_ratingCmbBox
            // 
            this.addMovie_ratingCmbBox.FormattingEnabled = true;
            this.addMovie_ratingCmbBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.addMovie_ratingCmbBox.Location = new System.Drawing.Point(247, 129);
            this.addMovie_ratingCmbBox.Name = "addMovie_ratingCmbBox";
            this.addMovie_ratingCmbBox.Size = new System.Drawing.Size(230, 21);
            this.addMovie_ratingCmbBox.TabIndex = 4;
            // 
            // AddMovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(615, 400);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddMovieForm";
            this.Text = "My Cinema";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }



        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent(Movie movie)
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.addMovie_label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addMovie_descriptionTxt = new System.Windows.Forms.RichTextBox();
            this.addMovie_submitBtn = new System.Windows.Forms.Button();
            this.addMovie_categoryCmbBox = new System.Windows.Forms.ComboBox();
            this.addMovie_datePicker = new System.Windows.Forms.DateTimePicker();
            this.addMovie_premiereDateLabel = new System.Windows.Forms.Label();
            this.addMovie_descriptionLabel = new System.Windows.Forms.Label();
            this.addMovie_categoryLabel = new System.Windows.Forms.Label();
            this.addMovie_titleTxt = new System.Windows.Forms.TextBox();
            this.addMovie_titleLabel = new System.Windows.Forms.Label();
            this.addMovie_idTxt = new System.Windows.Forms.TextBox();
            this.addMovie_idLabel = new System.Windows.Forms.Label();
            this.addMovie_ratingLabel = new System.Windows.Forms.Label();
            this.addMovie_ratingCmbBox = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addMovie_label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 35);
            this.panel1.TabIndex = 0;
            // 
            // addMovie_label
            // 
            this.addMovie_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.addMovie_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addMovie_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMovie_label.ForeColor = System.Drawing.Color.White;
            this.addMovie_label.Location = new System.Drawing.Point(0, 0);
            this.addMovie_label.Name = "addMovie_label";
            this.addMovie_label.Size = new System.Drawing.Size(615, 35);
            this.addMovie_label.TabIndex = 0;
            this.addMovie_label.Text = "Add/Edit Movie";
            this.addMovie_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.addMovie_descriptionTxt);
            this.panel2.Controls.Add(this.addMovie_submitBtn);
            this.panel2.Controls.Add(this.addMovie_ratingCmbBox);
            this.panel2.Controls.Add(this.addMovie_categoryCmbBox);
            this.panel2.Controls.Add(this.addMovie_datePicker);
            this.panel2.Controls.Add(this.addMovie_premiereDateLabel);
            this.panel2.Controls.Add(this.addMovie_ratingLabel);
            this.panel2.Controls.Add(this.addMovie_descriptionLabel);
            this.panel2.Controls.Add(this.addMovie_categoryLabel);
            this.panel2.Controls.Add(this.addMovie_titleTxt);
            this.panel2.Controls.Add(this.addMovie_titleLabel);
            this.panel2.Controls.Add(this.addMovie_idTxt);
            this.panel2.Controls.Add(this.addMovie_idLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(615, 365);
            this.panel2.TabIndex = 1;
            // 
            // addMovie_descriptionTxt
            // 
            this.addMovie_descriptionTxt.Location = new System.Drawing.Point(247, 171);
            this.addMovie_descriptionTxt.Name = "addMovie_descriptionTxt";
            this.addMovie_descriptionTxt.Text = movie.Description;
            this.addMovie_descriptionTxt.Size = new System.Drawing.Size(230, 84);
            this.addMovie_descriptionTxt.TabIndex = 6;
            this.addMovie_descriptionTxt.Text = "";
            // 
            // addMovie_submitBtn
            // 
            this.addMovie_submitBtn.Location = new System.Drawing.Point(247, 316);
            this.addMovie_submitBtn.Name = "addMovie_submitBtn";
            this.addMovie_submitBtn.Size = new System.Drawing.Size(75, 23);
            this.addMovie_submitBtn.TabIndex = 5;
            this.addMovie_submitBtn.Text = "Submit";
            this.addMovie_submitBtn.UseVisualStyleBackColor = true;
            this.addMovie_submitBtn.Click += new System.EventHandler(this.addMovie_submitBtn_Click);
            // 
            // addMovie_categoryCmbBox
            // 
            this.addMovie_categoryCmbBox.FormattingEnabled = true;
            this.addMovie_categoryCmbBox.Items.AddRange(new object[] {
            "Action",
            "Comedy",
            "Drama",
            "Western",
            "Criminal"});
            this.addMovie_categoryCmbBox.Text = movie.Category;
            this.addMovie_categoryCmbBox.Location = new System.Drawing.Point(247, 91);
            this.addMovie_categoryCmbBox.Name = "addMovie_categoryCmbBox";
            this.addMovie_categoryCmbBox.Size = new System.Drawing.Size(230, 21);
            this.addMovie_categoryCmbBox.TabIndex = 4;
            // 
            // addMovie_datePicker
            // 
            this.addMovie_datePicker.Location = new System.Drawing.Point(247, 272);
            this.addMovie_datePicker.Name = "addMovie_datePicker";
            this.addMovie_datePicker.Value = movie.PremiereDate;
            this.addMovie_datePicker.Size = new System.Drawing.Size(230, 20);
            this.addMovie_datePicker.TabIndex = 3;
            // 
            // addMovie_premiereDateLabel
            // 
            this.addMovie_premiereDateLabel.AutoSize = true;
            this.addMovie_premiereDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMovie_premiereDateLabel.ForeColor = System.Drawing.Color.White;
            this.addMovie_premiereDateLabel.Location = new System.Drawing.Point(112, 272);
            this.addMovie_premiereDateLabel.Name = "addMovie_premiereDateLabel";
            this.addMovie_premiereDateLabel.Size = new System.Drawing.Size(111, 20);
            this.addMovie_premiereDateLabel.TabIndex = 1;
            this.addMovie_premiereDateLabel.Text = "Premiere Date";
            // 
            // addMovie_descriptionLabel
            // 
            this.addMovie_descriptionLabel.AutoSize = true;
            this.addMovie_descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMovie_descriptionLabel.ForeColor = System.Drawing.Color.White;
            this.addMovie_descriptionLabel.Location = new System.Drawing.Point(134, 202);
            this.addMovie_descriptionLabel.Name = "addMovie_descriptionLabel";
            this.addMovie_descriptionLabel.Size = new System.Drawing.Size(89, 20);
            this.addMovie_descriptionLabel.TabIndex = 1;
            this.addMovie_descriptionLabel.Text = "Description";
            // 
            // addMovie_categoryLabel
            // 
            this.addMovie_categoryLabel.AutoSize = true;
            this.addMovie_categoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMovie_categoryLabel.ForeColor = System.Drawing.Color.White;
            this.addMovie_categoryLabel.Location = new System.Drawing.Point(150, 89);
            this.addMovie_categoryLabel.Name = "addMovie_categoryLabel";
            this.addMovie_categoryLabel.Size = new System.Drawing.Size(73, 20);
            this.addMovie_categoryLabel.TabIndex = 1;
            this.addMovie_categoryLabel.Text = "Category";
            // 
            // addMovie_titleTxt
            // 
            this.addMovie_titleTxt.Location = new System.Drawing.Point(247, 54);
            this.addMovie_titleTxt.Name = "addMovie_titleTxt";
            this.addMovie_titleTxt.Text = movie.Title;
            this.addMovie_titleTxt.Size = new System.Drawing.Size(230, 20);
            this.addMovie_titleTxt.TabIndex = 2;
            // 
            // addMovie_titleLabel
            // 
            this.addMovie_titleLabel.AutoSize = true;
            this.addMovie_titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMovie_titleLabel.ForeColor = System.Drawing.Color.White;
            this.addMovie_titleLabel.Location = new System.Drawing.Point(185, 54);
            this.addMovie_titleLabel.Name = "addMovie_titleLabel";
            this.addMovie_titleLabel.Size = new System.Drawing.Size(38, 20);
            this.addMovie_titleLabel.TabIndex = 1;
            this.addMovie_titleLabel.Text = "Title";
            // 
            // addMovie_idTxt
            // 
            this.addMovie_idTxt.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.addMovie_idTxt.Enabled = false;
            this.addMovie_idTxt.Location = new System.Drawing.Point(247, 18);
            this.addMovie_idTxt.Name = "addMovie_idTxt";
            this.addMovie_idTxt.Text = movie.Id.ToString();
            this.addMovie_idTxt.Size = new System.Drawing.Size(230, 20);
            this.addMovie_idTxt.TabIndex = 2;
            // 
            // addMovie_idLabel
            // 
            this.addMovie_idLabel.AutoSize = true;
            this.addMovie_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMovie_idLabel.ForeColor = System.Drawing.Color.White;
            this.addMovie_idLabel.Location = new System.Drawing.Point(200, 18);
            this.addMovie_idLabel.Name = "addMovie_idLabel";
            this.addMovie_idLabel.Size = new System.Drawing.Size(23, 20);
            this.addMovie_idLabel.TabIndex = 1;
            this.addMovie_idLabel.Text = "Id";
            // 
            // addMovie_ratingLabel
            // 
            this.addMovie_ratingLabel.AutoSize = true;
            this.addMovie_ratingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMovie_ratingLabel.ForeColor = System.Drawing.Color.White;
            this.addMovie_ratingLabel.Location = new System.Drawing.Point(167, 127);
            this.addMovie_ratingLabel.Name = "addMovie_ratingLabel";
            this.addMovie_ratingLabel.Size = new System.Drawing.Size(56, 20);
            this.addMovie_ratingLabel.TabIndex = 1;
            this.addMovie_ratingLabel.Text = "Rating";
            // 
            // addMovie_ratingCmbBox
            // 
            this.addMovie_ratingCmbBox.FormattingEnabled = true;
            this.addMovie_ratingCmbBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.addMovie_ratingCmbBox.Location = new System.Drawing.Point(247, 129);
            this.addMovie_ratingCmbBox.Name = "addMovie_ratingCmbBox";
            this.addMovie_ratingCmbBox.Text = movie.Rating.ToString();
            this.addMovie_ratingCmbBox.Size = new System.Drawing.Size(230, 21);
            this.addMovie_ratingCmbBox.TabIndex = 4;
            // 
            // AddMovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(615, 400);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddMovieForm";
            this.Text = "My Cinema";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label addMovie_label;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button addMovie_submitBtn;
        private System.Windows.Forms.ComboBox addMovie_categoryCmbBox;
        private System.Windows.Forms.DateTimePicker addMovie_datePicker;
        private System.Windows.Forms.Label addMovie_premiereDateLabel;
        private System.Windows.Forms.Label addMovie_descriptionLabel;
        private System.Windows.Forms.Label addMovie_categoryLabel;
        private System.Windows.Forms.TextBox addMovie_titleTxt;
        private System.Windows.Forms.Label addMovie_titleLabel;
        private System.Windows.Forms.TextBox addMovie_idTxt;
        private System.Windows.Forms.Label addMovie_idLabel;
        private System.Windows.Forms.RichTextBox addMovie_descriptionTxt;
        private System.Windows.Forms.ComboBox addMovie_ratingCmbBox;
        private System.Windows.Forms.Label addMovie_ratingLabel;
    }
}