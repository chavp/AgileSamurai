using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MongoDB.Bson.Serialization.Attributes;

namespace WarStory.Domain
{
    public abstract class Actor
    {
        public Actor()
        {
            Updated = DateTime.UtcNow;
            Created = DateTime.UtcNow;
            Level = 1;
        }

        [BsonId]
        public string Name { get; set; }
        public DateTime Updated { get; set; }
        public DateTime Created { get; set; }
        public byte Level { get; set; }

        public virtual void Action()
        {
        }
    }
}
