using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Story3.Domain
{
    public class Carpet : Actor
    {
        public string Color { get; set; }

        public override string Name
        {
            get
            {
                return Color + " Carpet";
            }
            set
            {
                base.Name = value;
            }
        }
    }
}
