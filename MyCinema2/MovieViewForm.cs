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
        private readonly Movie Movie;
        private readonly Panel MainPanel;

        /// <summary>
        /// Construtor which uses passed movie to populate detailed view's table and 
        /// </summary>
        /// <param name="Movie">Passed movie from previous form</param>
        /// <param name="MainPanel">Passed main panel</param>
        public Form3(Movie movie, Panel MainPanel)
        {
            this.Movie = movie;
            this.MainPanel = MainPanel;

            InitializeComponent();
            PopulateTable();
            ApplyTableChanges();

        }

        /// <summary>
        /// Method used to create cells and rows in our table
        /// </summary>
        private void PopulateTable()
        {
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dataGridView1);
            row.Cells[0].Value = "Title";
            row.Cells[1].Value = Movie.Title;
            dataGridView1.Rows.Add(row);


            row = new DataGridViewRow();
            row.CreateCells(dataGridView1);
            row.Cells[0].Value = "Category";
            row.Cells[1].Value = Movie.Category;
            dataGridView1.Rows.Add(row);


            row = new DataGridViewRow();
            row.CreateCells(dataGridView1);
            row.Cells[0].Value = "Rating";
            row.Cells[1].Value = Movie.Rating;
            dataGridView1.Rows.Add(row);


            row = new DataGridViewRow();
            row.CreateCells(dataGridView1);
            row.Cells[0].Value = "Description";
            row.Cells[1].Value = Movie.Description;
            dataGridView1.Rows.Add(row);

            row = new DataGridViewRow();
            row.CreateCells(dataGridView1);
            row.Cells[0].Value = "Premiere Date";
            row.Cells[1].Value = Movie.PremiereDate.ToString();
            dataGridView1.Rows.Add(row);

            row = new DataGridViewRow();
            row.CreateCells(dataGridView1);
            row.Cells[0].Value = "Date added";
            row.Cells[1].Value = Movie.DateAdded.ToString();
            dataGridView1.Rows.Add(row);

            row = new DataGridViewRow();
            row.CreateCells(dataGridView1);
            row.Cells[0].Value = "Database Id";
            row.Cells[1].Value = Movie.Id.ToString();
            dataGridView1.Rows.Add(row);
        }


        /// <summary>
        /// Method used to apply post creation DataGridView changes
        /// </summary>
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



        /// <summary>
        /// Method which opens movie in web-app using default browser
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void viewItem_viewOnlineBtn_Click(object sender, EventArgs e)
        {
            Process.Start("http://13.53.159.1:8080/view-movie?id=" + Movie.Id);
        }

        /// <summary>
        /// Method which opens AddMovieForm using this movie to populate fields in that form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void viewItem_editBtn_Click(object sender, EventArgs e)
        {
            SetMainForm(new AddMovieForm(Movie));
        }

        /// <summary>
        /// Method which sends request to delete movie in database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void viewItem_removeBtn_Click(object sender, EventArgs e)
        {
            Utils.DeleteDocument(Movie);
            SetMainForm(new Form2(MainPanel));
        }

        /// <summary>
        /// Method used to fill right panel of main form
        /// </summary>
        /// <param name="passedForm"></param>
        private void SetMainForm(Form passedForm)
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
