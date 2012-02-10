using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Story3.Domain;

namespace Story3
{
    [TestClass]
    public class Story3TestCase
    {
        [TestMethod]
        public void Story3Case()
        {
            //http://www.bangkokpost.com/learning/learning-together/278662/k-pop-groupie-has-his-ticket
            //“The Korean pop group Girls’ Generation poses on the red carpet at the MNET Asian Music Awards ceremony in Singapore last November.”

            WorldTime.LastNovember(new Korean().GetPopulationByName<GirlsGeneration>("Girls’ Generation").Poses().On(new Carpet { Color = "Red" }).At(new MNETAsianMusicAwards()).In(new Singapore()));
        }
    }
}
