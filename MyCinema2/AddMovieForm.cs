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

namespace MyCinema2
{
    public partial class AddMovieForm : Form
    {
        private Movie passedMovie;

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
        /// <param name="movie"></param>
        public AddMovieForm(Movie movie)
        {
            passedMovie = movie;
            InitializeComponent();

            PopulateForm();
        }

        /// <summary>
        /// Method used to populate fields in our form
        /// </summary>
        private void PopulateForm()
        {
            addMovie_titleTxt.Text = passedMovie.Title;
            addMovie_ratingCmbBox.Text = passedMovie.Rating.ToString();
            addMovie_idTxt.Text = passedMovie.Id.ToString();
            addMovie_descriptionTxt.Text = passedMovie.Description;
            addMovie_datePicker.Value = passedMovie.PremiereDate;
            addMovie_categoryCmbBox.Text = passedMovie.Category.ToString();
        }

        /// <summary>
        /// Method used to validate input and send request to MongoDB database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addMovie_submitBtn_Click(object sender, EventArgs e)
        {
            MongoClient mongoClient = new MongoClient("mongodb://W60113:asd123@13.53.159.1:27017");
            IMongoDatabase db = mongoClient.GetDatabase("my_cinema");
            IMongoCollection<Movie> collection = db.GetCollection<Movie>("movies");


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

            Movie movie = null;

            // movie exists
            if (passedMovie != null)
            {
                movie = collection.Find(m => m.Id.Equals(passedMovie.Id)).Limit(1).Single();
                movie.Title = addMovie_titleTxt.Text;
                movie.Category = addMovie_categoryCmbBox.Text;
                movie.Description = addMovie_descriptionTxt.Text;
                movie.Rating = Int32.Parse(addMovie_ratingCmbBox.Text);
                movie.PremiereDate = addMovie_datePicker.Value;
                collection.ReplaceOne(m => m.Id.Equals(passedMovie.Id), movie);
            }
            else
            {
                movie = new Movie(addMovie_titleTxt.Text, addMovie_categoryCmbBox.Text, Int32.Parse(addMovie_ratingCmbBox.Text), addMovie_descriptionTxt.Text, DateTime.Now, addMovie_datePicker.Value);
                collection.InsertOne(movie);
            }


        }


    }
}
