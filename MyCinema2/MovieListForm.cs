using MongoDB.Driver;
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
    public partial class Form2 : Form
    {
        private List<Movie> movieList;
        private Panel MainPanel;


        /// <summary>
        /// Method used to apply post creation DataGridView changes
        /// </summary>
        private void ApplyTableChanges()
        {
            // hide ID, Description and premiere date columns as they get automaticaly added but we dont need them
            dataGridView.Columns["Id"].Visible = false;
            dataGridView.Columns["Description"].Visible = false;
            dataGridView.Columns["PremiereDate"].Visible = false;

            // resize columns
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            //change font size
            dataGridView.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11);
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11);

            // change headers background color
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
            dataGridView.EnableHeadersVisualStyles = false;

            // stripping
            this.dataGridView.RowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.dataGridView.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));

            // border
            dataGridView.BorderStyle = BorderStyle.None;

            // white font
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView.DefaultCellStyle.ForeColor = Color.White;

            // text aligment
            dataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        /// <summary>
        /// Constructor with MainForm panel as parameter
        /// </summary>
        /// <param name="panel"></param>
        public Form2(Panel panel)
        {
            this.MainPanel = panel;

            InitializeComponent();

            movieList = Utils.AllDocumentsToList();
            dataGridView.DataSource = movieList;

            ApplyTableChanges();
        }

        /// <summary>
        /// Method used create detailed view of clicked object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            string id = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();

            Movie movie = movieList.Find(m => m.Id.ToString().Equals(id));

            if (movie != null)
            {
                Console.WriteLine("Found Movie, redirecting");
                setMainForm(new Form3(movie, MainPanel));
            }
            else
            {
                Console.WriteLine("Something went wrong");
            }



        }


        /// <summary>
        /// Method used to fill right panel of main form
        /// </summary>
        /// <param name="passedForm"></param>
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
