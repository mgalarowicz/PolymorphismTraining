using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballApp
{
    class Striker:Player
    {


        private int[] skills = new int[4];
        private int[] stats = new int[3];
        private int[] physio = new int[3];

        public Striker(string name = "NoName", int[] skills = null, int effectivness = 0, int[] stats = null, object[] physio = null)
        {
            Console.WriteLine();
            Console.WriteLine("Striker");
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



        public override int Skills(int finishing, int heading, int longShots, int decisions)
        {
            int sumSkills = 3 * finishing + 1 * heading + 1 * longShots + 1 * decisions;
            Console.WriteLine();
            Console.WriteLine($"Finishing: {finishing}/20");
            Console.WriteLine($"Heading: {heading}/20");
            Console.WriteLine($"Long Shots: {longShots}/20");
            Console.WriteLine($"Decisions: {decisions}/20");
            return sumSkills;
        }

        public override int Statistics(int goals, int shots, int games)
        {
            Console.WriteLine();
            Console.WriteLine($"Goals: {goals}/season");
            Console.WriteLine($"Shots: {shots}/season");
            Console.WriteLine($"Games: {games}");

            return goals;
        }


    }
}
