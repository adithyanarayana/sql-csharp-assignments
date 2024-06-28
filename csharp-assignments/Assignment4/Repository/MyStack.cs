using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment4.Repository
{

    // Generic stack class
    public class MyStack<T>
    {

        private List<T> elements;


        public MyStack()
        {
            elements = new List<T>();
        }


        public int Count()
        {
            return elements.Count;
        }


        public T Pop()
        {
            if (elements.Count == 0)
            {
                throw new InvalidOperationException("The stack is empty.");
            }

            T item = elements[elements.Count - 1];
            elements.RemoveAt(elements.Count - 1);
            return item;
        }


        public void Push(T item)
        {
            elements.Add(item);
        }
    }
}
