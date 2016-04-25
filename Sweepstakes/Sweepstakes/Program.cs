using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Program
    {
        static void Main(string[] args)
        {
            Systemstring lengthword = new Systemstring("Water sucks");
            SystemArrayString arrays = new SystemArrayString();
            SystemLinkedListString reglink = new SystemLinkedListString();
            reglink.Insert(" Likes to eat cats",0);
            reglink.Length();
            arrays.Insert("Watermelons", 2);
            arrays.Length();
            arrays.Remove(0, 1);
            lengthword.Insert("Tommy", 2);
            lengthword.Remove(1, 10);
            lengthword.Length();
            lengthword.ToString();



        }
    }
}
