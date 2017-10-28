using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedProject
{
    public class LinkedStack : IFace
    {
    private Node top;

    public LinkedStack()
    {
        top = null;
    }

    public Object Push(Object newItem)
        {
            if(newItem == null)
            {
                return null;
            }
            Node newNode = new Node(newItem, top);
            top = newNode;
            return newItem;
        }
    public Object Pop()
        {
            if(isEmpty())
            {
                return null;
            }
            Object topItem = top.data;
            top = top.next;
            return topItem;

        }
    public Object Peek()
        {
            if(isEmpty())
            {
                return null;
            }
            return top.data;

        }
    public bool IsEmpty()
        {
            return top == null;
        }
    public void Clear()
        {
            top = null;
        }

    }
   
}
