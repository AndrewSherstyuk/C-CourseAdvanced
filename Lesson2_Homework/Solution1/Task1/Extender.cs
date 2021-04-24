using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    static class Extender
    {
        public static T[] GetArray<T>(this MyList<T> collection, params T[] newItems)
        {        
            MyList<T> newElements = new MyList<T>(newItems);            
            for (int i = 0; i < newElements.Count; i++)
            {
                collection.Add(newElements[i]);
            }

            T[] newArray = new T[collection.Count];
            for (int j = 0; j < collection.Count; j++)
            {
                newArray[j] = collection[j];
            }

            return newArray;
        }
    }
}
