using MongoDB.Driver;
using MyCinema;
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
    public partial class AddMovieForm : Form
    {
        private readonly Movie PassedMovie;

        /// <summary>
        /// Default form constructor
        /// </summary>
        public AddMovieForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Form constructor with movie parameter used to populate fields in our form
        /// </summary>
        /// <param name="Movie">Movie reference passed from detailed view</param>
        public AddMovieForm(Movie movie)
        {
            PassedMovie = movie;
            InitializeComponent();
            PopulateForm();
        }

        /// <summary>
        /// Method used to populate fields in our form
        /// </summary>
        private void PopulateForm()
        {
            addMovie_titleTxt.Text = PassedMovie.Title;
            addMovie_ratingCmbBox.Text = PassedMovie.Rating.ToString();
            addMovie_idTxt.Text = PassedMovie.Id.ToString();
            addMovie_descriptionTxt.Text = PassedMovie.Description;
            addMovie_datePicker.Value = PassedMovie.PremiereDate;
            addMovie_categoryCmbBox.Text = PassedMovie.Category.ToString();
        }

        /// <summary>
        /// Method used to validate input and send request to MongoDB database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addMovie_submitBtn_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(addMovie_titleTxt.Text))
            {
                MessageBox.Show("Title cannot be empty");
                return;
            }
            else if (string.IsNullOrEmpty(addMovie_categoryCmbBox.Text))
            {
                MessageBox.Show("Category cannot be empty");
                return;
            }
            else if (string.IsNullOrEmpty(addMovie_ratingCmbBox.Text))
            {
                MessageBox.Show("Rating cannot be empty");
                return;
            }
            else if (string.IsNullOrEmpty(addMovie_descriptionTxt.Text))
            {
                MessageBox.Show("Description cannot be empty");
                return;
            }
            else if (string.IsNullOrEmpty(addMovie_datePicker.Value.ToString()))
            {
                MessageBox.Show("Date cannot be empty");
                return;
            }

            Movie Movie;

            // movie exists
            if (PassedMovie != null)
            {
                Movie = Utils.FindById(PassedMovie.Id);

                Movie.Title = addMovie_titleTxt.Text;
                Movie.Category = addMovie_categoryCmbBox.Text;
                Movie.Description = addMovie_descriptionTxt.Text;
                Movie.Rating = Int32.Parse(addMovie_ratingCmbBox.Text);
                Movie.PremiereDate = addMovie_datePicker.Value;

                Utils.UpdateDocumentById(Movie.Id,Movie);
            }
            else
            {
                Movie = new Movie(addMovie_titleTxt.Text, addMovie_categoryCmbBox.Text, Int32.Parse(addMovie_ratingCmbBox.Text), addMovie_descriptionTxt.Text, DateTime.Now, addMovie_datePicker.Value);
                Utils.InsertDocument(Movie);
            }


        }


    }
}
