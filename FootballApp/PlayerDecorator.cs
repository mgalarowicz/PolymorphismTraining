using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballApp
{
    public class PlayerDecorator : Player
    {
        protected Player _player;

        public PlayerDecorator (Player player)
        {
            _player = player;
        }

        public override string Position()
        {
            return _player.Position();
        }

        public override int Skills()
        {
            return _player.Skills();
        }

        public override double Statistics()
        {
            return _player.Statistics();
        }
    }
}
