using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{


    class Systemstring : Icustomstring
    {
      

        public string stringToinsert;
        
        public Systemstring(string stringToinsert)
        {

            this.stringToinsert = stringToinsert;
        }
 
        public void Insert(string stringToInsert,int StartIndex)
        {
            stringToInsert = stringToinsert;
            stringToInsert = stringToinsert.Insert(StartIndex, "Alligators suck");
            Console.WriteLine(stringToInsert);

        }

        public int Length()
        {
            Console.WriteLine(stringToinsert.Length);
            return stringToinsert.Length;
        }
        public void Remove(int startIndex, int numCharsToRemove)
        {
           
            stringToinsert = stringToinsert.Remove(startIndex, numCharsToRemove);

            Console.WriteLine(stringToinsert);

        }

        public override string ToString()
        {
            stringToinsert = stringToinsert.ToString();
            Console.WriteLine(String.Format(stringToinsert));
            //string string_data = String.Format("You've entered: {0} ", stringToinsert);

            //string modified_data = String.Format("\nModified String: {0}\n", Insert());

            //string removal_data = String.Format("String (char) Removal:  {0}\n", Remove(StartIndex,NumCharsToRemove));

            //string length_data = String.Format("Length of string {0} char.\n", Length());

            //Console.WriteLine(string_data + modified_data + removal_data + length_data);

            //return string_data + modified_data + removal_data + length_data;
            return null;
        }
    }
}
