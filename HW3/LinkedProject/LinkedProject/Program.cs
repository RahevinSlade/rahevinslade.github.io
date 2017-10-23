using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedProject
{
    interface IFace
    {
        Object push(Object newItem);
        Object pop();
        Object peek();
        bool isEmpty();
        void clear();
    }
    public class LinkedStack
    {

    }
   
}
