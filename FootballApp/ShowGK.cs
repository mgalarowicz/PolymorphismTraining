using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballApp
{
    class ShowGK : Goalkeeper, IShowPlayerProfile
    {
        public ShowGK(string name = "NoName", int[] skills = null, int effectivness = 0, int[] stats = null, object[] physio = null) : base(name, skills, effectivness, stats, physio)
        {
            Name = Name;
            Effectivness = effectivness;

            if (skills == null || skills.Length != 4)
            {
                ShowSkills(0, 0, 0, 0);
            }
            else
            {
                ShowSkills(skills[0], skills[1], skills[2], skills[3]);
            }


            if (stats == null || stats.Length != 3)
            {
                ShowStats(0, 0, 0);
            }
            else
            {
                ShowStats(stats[0], stats[1], stats[2]);
            }


            if (physio == null || physio.Length != 3)
            {
                ShowPhysio(0, 0, "None");
            }
            else
            {
                ShowPhysio((int)physio[0], (int)physio[1], physio[2].ToString());
            }
        }


        public void ShowPhysio(int height, int weight, string footed)
        {
            Console.WriteLine("Height: {0}", height);
            Console.WriteLine("Weight: {0}", weight);
            Console.WriteLine("Footed: {0}", footed);
        }

        public void ShowSkills(int handling, int communication, int oneToOnes, int reflex)
        {
            Console.WriteLine($"Handling: {handling}/20");
            Console.WriteLine($"Communication: {communication}/20");
            Console.WriteLine($"One to ones: {oneToOnes}/20");
            Console.WriteLine($"Reflex: {reflex}/20");
        }

        public void ShowStats(int goalsConceded, int saves, int games)
        {
            Console.WriteLine();
            Console.WriteLine($"Goals Conceded: {goalsConceded}/season");
            Console.WriteLine($"Saves: {saves}/season");
            Console.WriteLine($"Games: {games}");
        }
    }
}
