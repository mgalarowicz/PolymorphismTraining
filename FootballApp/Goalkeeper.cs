using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballApp
{
    class Goalkeeper : Player
    {
        private int[] skills = new int[4];
        private int[] stats = new int[3];
        private int[] physio = new int[3];

        public Goalkeeper(string name = "NoName", int[] skills = null, int effectivness = 0, int[] stats = null, object[] physio = null)
        {
            Name = Name;
            Effectivness = effectivness;

            if (skills == null || skills.Length != 4)
            {
                Skills(0, 0, 0, 0);
            }
            else
            {
                Skills(skills[0], skills[1], skills[2], skills[3]);
            }


            if (stats == null || stats.Length != 3)
            {
                Statistics(0, 0, 0);
            }
            else
            {
                Statistics(stats[0], stats[1], stats[2]);
            }


            if (physio == null || physio.Length != 3)
            {
                PhysicalConditions(0, 0, "None");
            }
            else
            {
                PhysicalConditions((int)physio[0], (int)physio[1], physio[2].ToString());
            }

        }

       

        public override int Skills(int handling, int communication, int oneToOnes, int reflex)
        {
            int sumSkills = 2 * handling + 1 * communication + 2 * oneToOnes + 1 * reflex;
            return sumSkills;
        }

        public override int Statistics(int goalsConceded, int saves, int games)
        {
            return goalsConceded;
        }

        
    }
}
