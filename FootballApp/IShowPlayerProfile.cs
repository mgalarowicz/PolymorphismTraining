using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballApp
{
    interface IShowPlayerProfile
    {
        void ShowSkills(int a, int b, int c, int d);
        void ShowStats(int a, int b, int c);
        void ShowPhysio(int a, int b, string c);
    }
}
