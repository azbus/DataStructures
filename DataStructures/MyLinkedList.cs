using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class MyLinkedList<T>
    {
        Node head;
        Node currentItem;
        int size;
        public MyLinkedList()
        {
            head = new Node(null, null);
            currentItem = head;
            size = 0;
        }

        public T Search(T key)
        {
            Node targetNode = head;
            while (targetNode != null && !EqualityComparer<T>.Default.Equals(targetNode.Value(), key))
                targetNode = targetNode.Next();

            return targetNode.Value();
        }
        private Node SearchNode(T key)
        {
            Node targetNode = head;
            while (targetNode != null && !EqualityComparer<T>.Default.Equals(targetNode.Value(), key))
                targetNode = targetNode.Next();

            return targetNode;
        }
        public void Delete(T key)
        {
            Node targetNode = SearchNode(key);
            if (targetNode.Previous() != null)
                targetNode.Previous().setNext(targetNode.Next());
            else
                head = targetNode.Next();

        }
        public void Add(T item)
        {
            if (size == 0)
            {
                head.setKey(item);
                currentItem = head;
                size++;
            }
            else
            {
                Node newItem = new Node(null, this.currentItem, item);
                currentItem.setNext(newItem);
                currentItem = newItem;
                size++;
            }
        }

        private class Node
        {
            Node next;
            Node prev;
            T key;
            public Node(Node next, Node prev)
            {
                this.next = next;
                this.prev = prev;
            }
            public Node(Node next, Node prev, T key)
            {
                this.next = next;
                this.prev = prev;
                this.key = key;
            }
            public void setNext(Node next)
            {
                this.next = next;
            }
            public void setPrevious(Node prev)
            {
                this.prev = prev;
            }
            public void setKey(T key)
            {
                this.key = key;
            }
            public Node Next()
            {
                return next;
            }
            public Node Previous()
            {
                return prev;
            }
            public T Value()
            {
                return key;
            }
        }
    }
    
}
