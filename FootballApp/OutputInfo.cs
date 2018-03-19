using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballApp
{
    public class OutputInfo
    {
        public static void Output(Player player)
        {
            Console.WriteLine("Position: {0}", player.Position());
            Console.WriteLine("Overall points: {0}", player.Skills());
            Console.WriteLine("Efficiency: {0:N2}", player.Statistics());
            Console.WriteLine();
        }
           
    }
}
