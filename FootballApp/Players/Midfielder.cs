using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballApp
{
    class Midfielder:Player
    {
        Random rnd = new Random();

        public override string Position()
        {
            return "Midfielder";
        }

        public override int Skills()
        {
            int f = rnd.Next(1, 20);
            int d = rnd.Next(1, 20);
            Dictionary<string, int> StrikerSkills = new Dictionary<string, int>() { { "Passing", f }, { "Dribbling", d } };

            foreach (KeyValuePair<string, int> kvp in StrikerSkills)
            {
                Console.WriteLine("Attribute: {0} = {1}", kvp.Key, kvp.Value);
            }

            int overall = f + d;

            return overall;

        }

        public override double Statistics()
        {
            int games = 10;
            int passes = rnd.Next(1, 100);
            Console.WriteLine("Passes: {0}, Games: {1}", passes, games);
            double effectivnes = (double)passes / games;
            return effectivnes;
        }

    }
}
