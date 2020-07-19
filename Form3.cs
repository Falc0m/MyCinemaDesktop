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
    public partial class Form3 : Form
    {
        private Movie movie = null;
        public Form3(Movie movie)
        {
            this.movie = movie;
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
    }
}
