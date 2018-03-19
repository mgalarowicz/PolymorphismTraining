using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballApp
{
    public class ExtraTrainingDecorator : PlayerDecorator
    {
        Random rnd = new Random();
        public ExtraTrainingDecorator(Player player) : base(player)
        {
        }

        public override int Skills()
        {
            int rando = rnd.Next(1, 10);
            Console.WriteLine("{0} had extra training and gain extra {1} overall points!", _player.Position(), rando);
            return base.Skills() + rando;
        }

        public override double Statistics()
        {
            int rando = rnd.Next(1, 3);
            Console.WriteLine("{0} had extra training and improved his efficiency by {1}!", _player.Position(), rando);
            return base.Statistics() + rando;
        }
    }
}
