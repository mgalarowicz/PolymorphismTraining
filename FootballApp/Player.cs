using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballApp
{
    abstract class Player
    {
        private int effectivness;

        public virtual int Effectivness
        {
            get { return effectivness; }
            set
            {

                if (value > 0 && value < 100)
                {
                    effectivness = value;
                }
                else
                {
                    effectivness = 0;
                };
            }

        }

        public string Name { get; set; }

        public abstract int Skills(int a, int b, int c, int d);

        public abstract int Statistics(int a, int b, int c);

        public virtual int PhysicalConditions(int height, int weight, string footed)
        {
            return height;
        }

    }
}
