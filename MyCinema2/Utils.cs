using MongoDB.Bson;
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
        private static readonly MongoClient Client = new MongoClient("mongodb://W60113:asd123@13.53.159.1:27017");
        private static readonly IMongoDatabase Db = Client.GetDatabase("my_cinema");
        private static readonly IMongoCollection<Movie> Collection = Db.GetCollection<Movie>("movies");

        /// <summary>
        /// Enum with names of our buttons from main panel
        /// </summary>
        public enum ButtonNames
        {
            None,
            ViewMovies,
            AddMovies,
            ViewOnline,
            AboutUs
        }

        /// <summary>
        /// Method used to fetch all documents from database
        /// </summary>
        /// <returns>List of movie objects if we manage to connect, null if not</returns>
        public static List<Movie> AllDocumentsToList()
        {
            List<Movie> MovieList = Collection.AsQueryable().ToList<Movie>();

            return MovieList.Count > 0 ? MovieList : null;
        }

        /// <summary>
        /// Method for inserting new movies into database
        /// </summary>
        /// <param name="movie">Passed movie reference</param>
        /// <returns>True if document has been inserted, False if document wasn't inserted</returns>        
        public static bool InsertDocument(Movie movie)
        {

            if (movie == null)
            {
                return false;
            }

            Collection.InsertOne(movie);

            return Collection.AsQueryable().Any(m => m.Title.Equals(movie.Title));
        }

        /// <summary>
        /// Method used to update existing items in database
        /// </summary>
        /// <param name="Id">ObjectId from passed movie</param>
        /// <param name="Replacement">Movie reference which will replace the movie</param>
        public static void UpdateDocumentById(ObjectId Id, Movie Replacement)
        {
            Collection.ReplaceOne(m => m.Id.Equals(Id), Replacement);
        }


        /// <summary>
        /// Method used to delete existing item from database
        /// </summary>
        /// <param name="movie">Movie reference for removal</param>
        public static void DeleteDocument(Movie movie)
        {
            Collection.DeleteOne(m => m.Id == movie.Id);
        }

        /// <summary>
        /// Method used to search database for document with Id
        /// </summary>
        /// <param name="Id">ObjectId of movie we want to search</param>
        /// <returns>Movie object if found, null if not</returns>
        public static Movie FindById(ObjectId Id)
        {
            return Collection.Find(m => m.Id.Equals(Id)).Limit(1).Single();
        }

    }
}
