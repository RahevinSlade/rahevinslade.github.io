using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedProject
{
    interface IFace
    {
        Object Push(Object newItem);
        Object Pop();
        Object Peek();
        bool IsEmpty();
        void Clear();
    }

}
