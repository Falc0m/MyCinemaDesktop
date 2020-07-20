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
        public AddMovieForm()
        {
            InitializeComponent();
        }


        public AddMovieForm(Movie movie)
        {
            passedMovie = movie;
            InitializeComponent(passedMovie);
        }

        private void addMovie_submitBtn_Click(object sender, EventArgs e)
        {
            MongoClient mongoClient = new MongoClient("mongodb://W60113:asd123@13.53.159.1:27017");
            IMongoDatabase db = mongoClient.GetDatabase("my_cinema");
            IMongoCollection<Movie> collection = db.GetCollection<Movie>("movies");

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
