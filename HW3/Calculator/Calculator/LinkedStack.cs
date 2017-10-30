using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator//This is where we will define the methods mentioned in the interface
{
    public class LinkedStack : IFace
    {
    private Node top;//Top of the node

    public LinkedStack()//creates the node, with null input
    {
        top = null;
    }

    public object Push(object newItem)
        {//"pushes"if the item is null do nothing, else place it on top of the stack
            if(newItem == null)
            {
                return null;
            }
            Node newNode = new Node(newItem, top);
            top = newNode;
            return newItem;
        }
    public object Pop()
        {//Here we remove the object on top.
            //and point to the next item
            if(IsEmpty())
            {
                return null;
            }
            object topItem = top.Data;
            top = top.Next;
            return topItem;

        }
    public object Peek()
        {//here we see what the data is in the top node
            if(IsEmpty())
            {
                return null;
            }
            return top.Data;

        }
    public bool IsEmpty()
        {//returns true or false if the stack is empty or not.
            return top == null;
        }
    public void Clear()
        {//erases everthing 
            top = null;
        }

    }
   
}
