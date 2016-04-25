using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    interface Icustomstring
    {
   
        void Insert(string stringToInsert,int startindex);
       void Remove(int startIndex, int numCharsToRemove);
        int Length();
        string ToString();
        
    }
}
