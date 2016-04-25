using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SystemArrayString : Icustomstring
    {
        char[] mystrings = { 'B', 'O', 'B' };
        public void Insert(string insertnewString, int startIndex)
        {
            {
                char[] stringToArray = insertnewString.ToCharArray();

                char[] combinedArray = new char[mystrings.Length + stringToArray.Length];

                Array.Copy(mystrings, 0, combinedArray, 0, startIndex);
                Array.Copy(stringToArray, 0, combinedArray, startIndex, stringToArray.Length);
                Array.Copy(mystrings, startIndex, combinedArray, startIndex + stringToArray.Length, mystrings.Length - startIndex);

                foreach (char character in combinedArray)
                {
                    Console.WriteLine(character);
                }
            }
        }



       
        public int Length()
        {
            char[] animals = { 'T','I','G','E','R', 'L','I','O','N' };
            Console.WriteLine(animals.Length);
      
            return animals.Length;
        }

        public void Remove(int startIndex, int numCharsToRemove)
        {
            char[] colors = { 'H', 'E', 'L', 'L', 'O' };
            char[] modifiedarray = { };
            for(int i = 0; i < numCharsToRemove; i++)
            {
              
            }

     

        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
