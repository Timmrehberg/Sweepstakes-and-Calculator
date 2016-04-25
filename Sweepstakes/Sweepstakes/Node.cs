using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Node
    {
        public string Value;
        public Node Next;


        public static void PrintList(Node node, string word)
        {
            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
                Console.WriteLine(word);
            }
        }


              public static void PrintLength(Node node,Node node2,Node node3)
        {
            
                Console.WriteLine(node.Value.Length + node2.Value.Length + node3.Value.Length);
                node = node.Next;
               
            


        }
    }
}