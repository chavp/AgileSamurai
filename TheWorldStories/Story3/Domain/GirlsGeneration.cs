using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Story3.Domain
{
    public class GirlsGeneration : Party
    {
        public Party Poses()
        {
            Console.WriteLine("poses");
            return this;
        }
    }
}
