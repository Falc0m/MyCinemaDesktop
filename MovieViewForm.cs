using MongoDB.Driver;
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
        }

        private void viewItem_viewOnlineBtn_Click(object sender, EventArgs e)
        {
            Process.Start("http://13.53.159.1:8080/movies/movie?id=" + movie.Id);
        }

        private void viewItem_editBtn_Click(object sender, EventArgs e)
        {

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
