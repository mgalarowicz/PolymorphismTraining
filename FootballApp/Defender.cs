using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballApp
{
    class Defender:Player
    {


        private int[] skills = new int[4];
        private int[] stats = new int[3];
        private int[] physio = new int[3];

        public Defender(string name = "NoName", int[] skills = null, int effectivness = 0, int[] stats = null, object[] physio = null)
        {
            Console.WriteLine();
            Console.WriteLine("Defender");
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



        public override int Skills(int marking, int tackling, int concentration, int positioning)
        {
            int sumSkills = 2 * marking + 2 * tackling + 1 * concentration + 1 * positioning;
            Console.WriteLine();
            Console.WriteLine($"Marking: {marking}/20");
            Console.WriteLine($"Tackling: {tackling}/20");
            Console.WriteLine($"Concentration: {concentration}/20");
            Console.WriteLine($"Positioning: {positioning}/20");
            return sumSkills;
        }

        public override int Statistics(int goalsConceded, int tackles, int games)
        {
            Console.WriteLine();
            Console.WriteLine($"Goals Conceded: {goalsConceded}/season");
            Console.WriteLine($"Tackles: {tackles}/season");
            Console.WriteLine($"Games: {games}");

            return goalsConceded;
        }


    }
}
