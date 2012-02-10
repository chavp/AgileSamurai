using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Story3.Domain
{
    public abstract class Party : Actor
    {
        public List<Party> Parties { get; set; }
    }

    public abstract class Person : Party
    {

    }


}
