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
            //QueueTest();
            ListTest();
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
        static void ListTest()
        {
            MyLinkedList<int> list = new MyLinkedList<int>();

            int N = 20;
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Try to Add num: " + i);
                list.Add(i);
            }
            int num = 6;
            Console.WriteLine("\nTry to Search num: " + num);
            int val = list.Search(num);
            Console.WriteLine("Finded number: " + val);
            num = 8;

            Console.WriteLine("\nTry to delete number: " + num);
            list.Delete(num);

            try
            {
                Console.WriteLine("Try to Search num: " + num);
                val = list.Search(num);
            }
            catch(Exception e)
            {
                Console.WriteLine("Number " + num + " not found");
            }

            Console.Read();
        }
    }
}
