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
        private Movie movie;
        public AddMovieForm()
        {
            InitializeComponent();
        }


        public AddMovieForm(Movie movie)
        {
            this.movie = movie;
            InitializeComponent();
        }

        private void addMovie_submitBtn_Click(object sender, EventArgs e)
        {
            MongoClient mongoClient = new MongoClient("mongodb://W60113:asd123@13.53.159.1:27017");
            IMongoDatabase db = mongoClient.GetDatabase("my_cinema");
            IMongoCollection<Movie> collection = db.GetCollection<Movie>("movies");

            Movie m = null;

            // movie exists
            if (addMovie_idTxt.Text.Length != 0)
            {
                // update code
            }
            else
            {
                m = new Movie(addMovie_titleTxt.Text, addMovie_categoryCmbBox.Text, Int32.Parse(addMovie_ratingCmbBox.Text), addMovie_descriptionTxt.Text);
            }


            collection.InsertOne(m);

        }


    }
}
