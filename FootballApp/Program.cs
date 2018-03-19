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
            Player Marek = new Striker();

            OutputInfo.Output(Marek);

            Marek = new ExtraTrainingDecorator(Marek);
            Marek = new PoorFoodDecorator(Marek);

            OutputInfo.Output(Marek);

            Player Darek = new Goalkeeper();
            OutputInfo.Output(Darek);

            Player Artur = new Defender();
            OutputInfo.Output(Artur);

            Player Marcin = new Midfielder();
            OutputInfo.Output(Marcin);

            Marcin = new ExtraTrainingDecorator(Marcin);
            OutputInfo.Output(Marcin);



            Console.ReadLine();
        }
    }
}
