using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using MongoDB.Bson.Serialization.Attributes;

namespace WarStory.Models
{
    public class Warehouse
    {
        [BsonId]
        public string Name { get; set; }

        public int Wood { get; set; }
        public int Stone { get; set; }
        public int Iron { get; set; }

        public void Action()
        {
            ++Wood;
            ++Stone;
            ++Iron;
        }
    }
}