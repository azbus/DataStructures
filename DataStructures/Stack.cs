using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class MyStack<T>
    {
        private int top;
        private T[] array;

        public MyStack()
        {
            top = 0;
            array = new T[top];
        }

        public bool isEmpty()
        {
            if (this.top == 0)
                return true;
            else
                return false;
        }
        public void Push(T x)
        {
            top++;
            Array.Resize(ref array, top);
            array[top-1] = x;
        }
        public T Pop()
        {
            if (isEmpty())
                throw new Exception("Underflow");
            else
                top--;
            T x = array[top];
            Array.Resize(ref array, top);
            return x;
        }
    }
}
