using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Story3.Domain
{
    public abstract class Ceremony : Party
    {
        public virtual Ceremony Register(Actor actor)
        {
            return this;
        }
    }
}
