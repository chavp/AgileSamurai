using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Story3.Domain
{
    public abstract class Actor
    {
        public virtual string Name { get; set; }
        public virtual Actor On(Actor actor)
        {
            Console.WriteLine("on");
            Console.WriteLine(actor.Name);
            return actor;
        }

	    public virtual Actor At(Actor actor)
        {
            Console.WriteLine("at");
            Console.WriteLine(actor.Name);
            return actor;
        }

        public virtual Actor In(Actor actor)
        {
            Console.WriteLine("in");
            Console.WriteLine(actor.Name);
            return actor;
        }
    }
}
