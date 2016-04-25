using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes
    {
        public string name { get; set; }
       public Sweepstakes(string Name)
        {
            name = Name;
        }

    void RegisterContestant(Contestant contestant)
        {

        }
    string PickWinner()
        {
            return name;
        }
    void PrintContestantInfo(Contestant contestant)
        {

        }
    }
}
