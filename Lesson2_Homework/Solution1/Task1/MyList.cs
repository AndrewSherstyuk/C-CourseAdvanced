using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class MyList<T> : IMyList<T>, IEnumerable<T>, IEnumerable, IEnumerator
    {          
        public T[] elementsArray = null;

        public MyList(params T[] elementsArray)
        {
            this.elementsArray = elementsArray;
        }

        int position = -1;

        object IEnumerator.Current
        {
            get { return elementsArray[position]; }
        }

        
        public int Count
        {
            get { return elementsArray.Length; } 
        }

        public T this[int index]
        {
            get { return elementsArray[index];  }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return elementsArray as IEnumerator;
        }

        public bool MoveNext()
        {
            if (position < elementsArray.Length - 1)
            {
                position++;
                return true;
            }
            else
                return false;
        }

        public void Reset()
        {
            position = -1;
        }

        public void Add(T a)
        {
            List<T> list = elementsArray.ToList();
            list.Add(a);
            elementsArray = list.ToArray();
        }

        public void Clear()
        {
            elementsArray.ToList().Clear();
        }

        public bool Contains(T item)
        {
            if (elementsArray.ToList().Contains(item))
            {
                return true;
            }
            else { return false; }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return elementsArray as IEnumerator<T>;
        }
    }
}

