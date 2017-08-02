using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            //StackTest();
            QueueTest();
        }

        static void StackTest()
        {
            int N = 20;
            MyStack<int> stack = new MyStack<int>();
            Console.WriteLine("\n Stack is empty: " + stack.isEmpty());

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Try to PUSH num: " + i);
                stack.Push(i);
            }

            Console.WriteLine("\n Stack is empty: " + stack.isEmpty());

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Try to PULL, number is: " + stack.Pop());
            }

            Console.WriteLine("\n Stack is empty: " + stack.isEmpty());

            Console.Read();
        }
        static void QueueTest()
        {
            int N = 8;
            MyQueue<int> queue = new MyQueue<int>();
            Console.WriteLine("\n Queue is full: " + queue.isFull());
            Console.WriteLine(" Queue is empty: " + queue.isEmpty());
            

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Try to Enqueue num: " + i);
                queue.Enqueue(i);
            }

            Console.WriteLine("\n Queue is full: " + queue.isFull());
            Console.WriteLine(" Queue is empty: " + queue.isEmpty());

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Try to Dequeue, number is: " + queue.Dequeue());
            }

            Console.WriteLine("\n Queue is full: " + queue.isFull());
            Console.WriteLine(" Queue is empty: " + queue.isEmpty());

            Console.Read();
        }
    }
}
