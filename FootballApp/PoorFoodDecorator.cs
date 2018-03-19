using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballApp
{
    public class PoorFoodDecorator : PlayerDecorator
    {
        Random rnd = new Random();
        public PoorFoodDecorator(Player player) : base(player)
        {
        }

        public override int Skills()
        {
            int rando = rnd.Next(1, 10);
            Console.WriteLine("{0} was eating in McDonalds and lost {1} overall points!", _player.Position(), rando);
            return base.Skills() - rnd.Next(1, 3);
        }

        public override double Statistics()
        {
            int rando = rnd.Next(1, 3);
            Console.WriteLine("{0} was eating in McDonalds and lost {1} of his efficiency!", _player.Position(), rando);
            return base.Statistics() - rando;
        }
    }
}
