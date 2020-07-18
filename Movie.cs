using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MyCinema2
{
    [BsonIgnoreExtraElements]
    class Movie
    {
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
