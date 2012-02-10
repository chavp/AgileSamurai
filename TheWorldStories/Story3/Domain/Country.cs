using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Story3.Domain
{
    public abstract class Country : Party
    {
        public T GetPopulationByName<T>(string name) where T : Party
        {
            T p = null;
            if (name == "Girls’ Generation")
            {
                Console.WriteLine(Name + " " + name);
                p = new GirlsGeneration() as T;
            }
            return p;
        }
    }
}
