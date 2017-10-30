using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Node
    {
        public object Data;
        public Node Next;

        public Node()//this is the creation of the node
        {
            Data = null;//carries but two item, the information, and whats next.
            Next = null;
        }

        public Node(object data, Node next)
        {
            Data = data;//this is the public node for all
            Next = next;
        }
    }
}
