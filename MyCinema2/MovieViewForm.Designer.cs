using System.Windows.Forms;

namespace MyCinema
{
    partial class Form3
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.movieView_topPanel_title = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewItem_removeBtn = new System.Windows.Forms.Button();
            this.viewItem_editBtn = new System.Windows.Forms.Button();
            this.viewItem_viewOnlineBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.movieView_topPanel_title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(718, 35);
            this.panel1.TabIndex = 0;
            // 
            // movieView_topPanel_title
            // 
            this.movieView_topPanel_title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.movieView_topPanel_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieView_topPanel_title.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.movieView_topPanel_title.Location = new System.Drawing.Point(0, 0);
            this.movieView_topPanel_title.Name = "movieView_topPanel_title";
            this.movieView_topPanel_title.Size = new System.Drawing.Size(718, 35);
            this.movieView_topPanel_title.TabIndex = 0;
            this.movieView_topPanel_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.Size = new System.Drawing.Size(620, 378);
            this.dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Field";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Value";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 500;
            // 
            // viewItem_removeBtn
            // 
            this.viewItem_removeBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.viewItem_removeBtn.Location = new System.Drawing.Point(392, 15);
            this.viewItem_removeBtn.Name = "viewItem_removeBtn";
            this.viewItem_removeBtn.Size = new System.Drawing.Size(75, 23);
            this.viewItem_removeBtn.TabIndex = 0;
            this.viewItem_removeBtn.Text = "Remove";
            this.viewItem_removeBtn.UseVisualStyleBackColor = true;
            this.viewItem_removeBtn.Click += new System.EventHandler(this.viewItem_removeBtn_Click);
            // 
            // viewItem_editBtn
            // 
            this.viewItem_editBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.viewItem_editBtn.Location = new System.Drawing.Point(311, 15);
            this.viewItem_editBtn.Name = "viewItem_editBtn";
            this.viewItem_editBtn.Size = new System.Drawing.Size(75, 23);
            this.viewItem_editBtn.TabIndex = 0;
            this.viewItem_editBtn.Text = "Edit";
            this.viewItem_editBtn.UseVisualStyleBackColor = true;
            this.viewItem_editBtn.Click += new System.EventHandler(this.viewItem_editBtn_Click);
            // 
            // viewItem_viewOnlineBtn
            // 
            this.viewItem_viewOnlineBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.viewItem_viewOnlineBtn.Location = new System.Drawing.Point(230, 15);
            this.viewItem_viewOnlineBtn.Name = "viewItem_viewOnlineBtn";
            this.viewItem_viewOnlineBtn.Size = new System.Drawing.Size(75, 23);
            this.viewItem_viewOnlineBtn.TabIndex = 0;
            this.viewItem_viewOnlineBtn.Text = "View online";
            this.viewItem_viewOnlineBtn.UseVisualStyleBackColor = true;
            this.viewItem_viewOnlineBtn.Click += new System.EventHandler(this.viewItem_viewOnlineBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panel2.Controls.Add(this.viewItem_editBtn);
            this.panel2.Controls.Add(this.viewItem_removeBtn);
            this.panel2.Controls.Add(this.viewItem_viewOnlineBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 472);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(718, 50);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(62, 78);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(620, 378);
            this.panel3.TabIndex = 3;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(718, 522);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
            this.Text = "My Cinema";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }




        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label movieView_topPanel_title;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button viewItem_removeBtn;
        private System.Windows.Forms.Button viewItem_editBtn;
        private System.Windows.Forms.Button viewItem_viewOnlineBtn;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Panel panel2;
        private Panel panel3;
    }
}