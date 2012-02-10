using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Story3.Domain
{
    public class MNETAsianMusicAwards : Ceremony
    {
        public override string Name
        {
            get
            {
                return "The MNET Asian Music Awards ceremony";
            }
            set
            {
                base.Name = value;
            }
        }
    }
}
