using MongoDB.Driver;
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
    public partial class Form3 : Form
    {
        private Movie movie;
        private Panel MainPanel;

        public Form3(Movie movie, Panel MainPanel)
        {
            this.movie = movie;
            this.MainPanel = MainPanel;

            InitializeComponent();
            PopulateTable();
            ApplyTableChanges();

        }

        private void PopulateTable()
        {
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dataGridView1);
            row.Cells[0].Value = "Title";
            row.Cells[1].Value = movie.Title;
            dataGridView1.Rows.Add(row);


            row = new DataGridViewRow();
            row.CreateCells(dataGridView1);
            row.Cells[0].Value = "Category";
            row.Cells[1].Value = movie.Category;
            dataGridView1.Rows.Add(row);


            row = new DataGridViewRow();
            row.CreateCells(dataGridView1);
            row.Cells[0].Value = "Rating";
            row.Cells[1].Value = movie.Rating;
            dataGridView1.Rows.Add(row);


            row = new DataGridViewRow();
            row.CreateCells(dataGridView1);
            row.Cells[0].Value = "Description";
            row.Cells[1].Value = movie.Description;
            dataGridView1.Rows.Add(row);

            row = new DataGridViewRow();
            row.CreateCells(dataGridView1);
            row.Cells[0].Value = "Premiere Date";
            row.Cells[1].Value = movie.PremiereDate.ToString();
            dataGridView1.Rows.Add(row);

            row = new DataGridViewRow();
            row.CreateCells(dataGridView1);
            row.Cells[0].Value = "Date added";
            row.Cells[1].Value = movie.DateAdded.ToString();
            dataGridView1.Rows.Add(row);

            row = new DataGridViewRow();
            row.CreateCells(dataGridView1);
            row.Cells[0].Value = "Database Id";
            row.Cells[1].Value = movie.Id.ToString();
            dataGridView1.Rows.Add(row);
        }


        private void ApplyTableChanges()
        {

            // resize columns
            dataGridView1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            //change font size
            dataGridView1.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11);

            // stripping
            this.dataGridView1.RowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));

            // border
            dataGridView1.BorderStyle = BorderStyle.None;

            // white font
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.DefaultCellStyle.ForeColor = Color.White;

            // text aligment
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }



        private void viewItem_viewOnlineBtn_Click(object sender, EventArgs e)
        {
            Process.Start("http://13.53.159.1:8080/view-movie?id=" + movie.Id);
        }

        private void viewItem_editBtn_Click(object sender, EventArgs e)
        {
            setMainForm(new AddMovieForm(movie));
        }

        private void viewItem_removeBtn_Click(object sender, EventArgs e)
        {
            MongoClient mongoClient = new MongoClient("mongodb://W60113:asd123@13.53.159.1:27017");
            IMongoDatabase db = mongoClient.GetDatabase("my_cinema");
            IMongoCollection<Movie> collection = db.GetCollection<Movie>("movies");

            collection.DeleteOne(m => m.Id == movie.Id);

            setMainForm(new Form2(MainPanel));
        }

        private void setMainForm(Form passedForm)
        {

            this.Close();
            Form1.activeForm = passedForm;

            passedForm.TopLevel = false;
            passedForm.FormBorderStyle = FormBorderStyle.None;
            passedForm.Dock = DockStyle.Fill;

            MainPanel.Controls.Add(passedForm);
            MainPanel.Tag = passedForm;

            passedForm.Show();

        }
    }
}
