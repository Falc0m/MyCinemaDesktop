using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MyCinema
{
    [BsonIgnoreExtraElements]
    public class Movie
    {
        public Movie(string title, string category, int rating, string description)
        {
            Title = title;
            Category = category;
            Rating = rating;
            Description = description;
        }

        public Movie()
        {
        }

        [BsonId]
        public Object Id { get; set; }

        [BsonElement("title")]
        public String Title { get; set; }

        [BsonElement("category")]
        public String Category { get; set; }

        [BsonElement("rating")]
        public int Rating { get; set; }

        [BsonElement("description")]
        public String Description { get; set; }

   
    }
}
