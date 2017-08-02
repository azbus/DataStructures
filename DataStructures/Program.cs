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
            StackTest();
        }

        static void StackTest()
        {
            int N = 20;
            MyStack<int> stack = new MyStack<int>();
            Console.WriteLine("\n Stack is empty: " + stack.isEmpty());

            Console.WriteLine("Try to PUSH nums: 0-19 ");
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
    }
}
