using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MongoDB.Bson.Serialization.Attributes;

namespace WarStoryServer.Domain
{
    public class Warehouse : Actor
    {
        [BsonId]
        public string Name { get; set; }

        public int Wood { get; set; }
        public int Stone { get; set; }
        public int Iron { get; set; }

        public override void Action()
        {
            ++Wood;
            ++Stone;
            ++Iron;
        }
    }
}
