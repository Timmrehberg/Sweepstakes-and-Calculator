using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sweepstakes
{
    class SystemLinkedListString : Icustomstring
    {
        public void Insert(string stringToInsert,int StartIndex)
        {
            Node first = new Node { Value = "Bob" };

            Node middle = new Node { Value = "Tom" };
            first.Next = middle;
            Node last = new Node { Value = "John" };
            middle.Next = last;
            Node.PrintList(first,"Eats cats");
        

        }

        public int Length()
        {
            Node first = new Node { Value = "Prince" };

            Node middle = new Node { Value = "Michael Jackson" };
            first.Next = middle;
            Node last = new Node { Value = "Rick James" };
            middle.Next = last;
            Node.PrintLength(first,middle,last);
            
            return 0;
         
        }

        public void Remove(int startIndex, int numCharsToRemove)
        {
            
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
