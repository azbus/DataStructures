using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class MyQueue<T>
    {
        private T[] array;
        private int length;
        private int head;
        private int tail;
        private int defaultLength = 10;

        public MyQueue()
        {
            head = 0;
            tail = 0;
            length = defaultLength;
            array = new T[length];
        }
        public MyQueue(int length)
        {
            head = 0;
            tail = 0;
            this.length = length;
            array = new T[this.length];
        }

        public void Enqueue(T x)
        {
            if (isFull())
                throw new Exception("Overflow");

            array[tail] = x;
            if (tail == length)
                tail = 1;
            else
                tail++;
        }
        public T Dequeue()
        {
            if (isEmpty())
                throw new Exception("UnderFlow");

            T x = array[head];
            if (head == length)
                head = 1;
            else
                head++;
            return x;
        }

        public int getLength()
        {
            return length;
        }

        public bool isEmpty()
        {
            if (tail == head)
                return true;
            else
                return false;
        }

        public bool isFull()
        {
            if ((head == tail + 1) || (head == 0 && tail == length))
                return true;
            else
                return false;
        }
    }
}
