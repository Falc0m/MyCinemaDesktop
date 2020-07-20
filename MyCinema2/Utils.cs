using MongoDB.Driver;
using MyCinema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyCinema
{
    public class Utils
    {
        private static MongoClient mongoClient = new MongoClient("mongodb://W60113:asd123@13.53.159.1:27017");
        private static IMongoDatabase db = mongoClient.GetDatabase("my_cinema");
        private static IMongoCollection<Movie> collection = db.GetCollection<Movie>("movies");

        public enum ButtonNames
        {
            None,
            ViewMovies,
            AddMovies,
            ViewOnline,
            AboutUs
        }


        public static List<Movie> AllDocumentsToList()
        {
            return collection.AsQueryable().ToList<Movie>();
        }

        public static bool InsertDocument(Movie movie)
        {

            if(movie == null)
            {
                return false;
            }

             collection.InsertOne(movie);

            return collection.AsQueryable().Any(m => m.Title.Equals(movie.Title));
        }


    }
}
