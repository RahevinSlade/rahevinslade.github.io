using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    interface IFace//Here is our interface, where we will create methods but not define them
    {//we will have push, pop, peek, and isempty, and clear
        object Push(object newItem);
        object Pop();
        object Peek();
        bool IsEmpty();
        void Clear();
    }

}
