using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WarStory.Domain
{
    public class Warehouse : Actor
    {
        public int Wood { get; protected set; }
        public int Stone { get; protected set; }
        public int Iron { get; protected set; }

        public int ForestLv { get; protected set; }
        public int MineLv { get; protected set; }
        public int MountainLv { get; protected set; }

        public Warehouse()
        {
            ForestLv = 1;
            MineLv = 1;
            MountainLv = 1;
        }

        public void Reset()
        {
            Wood = 0;
            Stone = 0;
            Iron = 0;

            ForestLv = 1;
            MineLv = 1;
            MountainLv = 1;

            Updated = DateTime.UtcNow;
        }

        public void UpgradeForest()
        {
            var costWood = ForestLv * 100;
            var costStone = ForestLv * 500;
            var costIron = ForestLv * 300;

            if (costWood <= Wood && costStone <= Stone && costIron <= Iron)
            {
                Wood -= costWood;
                Stone -= costStone;
                Iron -= costIron;

                ++ForestLv;
            }
        }
        public void UpgradeMountain()
        {
            var costWood = MountainLv * 300;
            var costStone = MountainLv * 100;
            var costIron = MountainLv * 500;

            if (costWood <= Wood && costStone <= Stone && costIron <= Iron)
            {
                Wood -= costWood;
                Stone -= costStone;
                Iron -= costIron;

                ++MountainLv;
            }
        }
        public void UpgradeMine()
        {
            var costWood = MineLv * 500;
            var costStone = MineLv * 300;
            var costIron = MineLv * 100;

            if (costWood <= Wood && costStone <= Stone && costIron <= Iron)
            {
                Wood -= costWood;
                Stone -= costStone;
                Iron -= costIron;

                ++MineLv;
            }
        }

        public override void Action()
        {
            TimeSpan delta = DateTime.UtcNow - Updated;

            int totalSeconds = (int)Math.Floor(delta.TotalSeconds);

            Wood += totalSeconds * ForestLv;
            Stone += totalSeconds * MineLv;
            Iron += totalSeconds * MountainLv;

            Updated = DateTime.UtcNow;
        }
    }
}
