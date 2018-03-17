using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Player Marek = new Goalkeeper("Marek", new int[] { }, 0, new int[] { }, new object[] { });

            Player Marek = new Goalkeeper();

            IShowPlayerProfile GK = new ShowGK();
            


            //Player Marcin = new Defender();

            //Player Tomek = new Midfielder();

            //Player Arek = new Striker();



            Console.ReadLine();
        }
    }
}
