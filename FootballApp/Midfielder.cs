﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballApp
{
    class Midfielder:Player
    {


        private int[] skills = new int[4];
        private int[] stats = new int[3];
        private int[] physio = new int[3];

        public Midfielder(string name = "NoName", int[] skills = null, int effectivness = 0, int[] stats = null, object[] physio = null)
        {
            Console.WriteLine();
            Console.WriteLine("Midfielder");
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



        public override int Skills(int passing, int firstTouch, int dribbling, int crossing)
        {
            int sumSkills = 3 * passing + 2 * firstTouch + 1 * dribbling + 1 * crossing;
            Console.WriteLine();
            Console.WriteLine($"Passing: {passing}/20");
            Console.WriteLine($"First Touch: {firstTouch}/20");
            Console.WriteLine($"Dribbling: {dribbling}/20");
            Console.WriteLine($"Crossing: {crossing}/20");
            return sumSkills;
        }

        public override int Statistics(int assists, int passes, int games)
        {
            Console.WriteLine();
            Console.WriteLine($"Assists: {assists}/season");
            Console.WriteLine($"Passes: {passes}/season");
            Console.WriteLine($"Games: {games}");

            return assists;
        }


    }
}