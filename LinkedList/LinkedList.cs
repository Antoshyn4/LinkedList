using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class LinkedList<T> where T : IComparable
    {
        public Node<T> first { get; private set; }
        public Node<T> last { get; private set; }
        public int Length { get; private set; }
        
        public LinkedList()
        {
            first = null;
            last = null;
            Length = 0;
        }
        public LinkedList(T data)
        {
            var node = new Node<T>(data);
            first = node;
            last = node;
            Length = 1;
        }
        public bool IsEmpty() 
        {
            if (Length == 0)
                return true;
            return false;
        }
        public void Print()
        {
            if (!IsEmpty())
            {
                for (Node<T> i = first; i != null; i = i.next)
                {
                    Console.WriteLine(i.data);
                }
            }
            else
                Console.WriteLine("Error, List is empty");
        }
        
        public void Add(T data)
        {
            var node = new Node<T>(data);
            if (IsEmpty())
            {
                first = node;
                last = node;
                Length = 1;
            }
            else if(Length == 1)
            {
                    if (node.data.CompareTo(first.data) >= 0)
                    {
                        first.next = node;
                        last = node;
                    }
                    else
                    {
                        first.next = first;
                        first = node;
                    }
                    Length++;
                    return;
            }
            else
            {
                if (node.data.CompareTo(last.data) >= 0)
                {
                    last.next = node;
                    last = node;
                }
                else if (node.data.CompareTo(first.data) <= 0)
                {
                    node.next = first;
                    first = node;
                }
                else
                {
                    for (Node<T> i = first; i != null; i = i.next)
                    {
                        if (node.data.CompareTo(i.data) >= 0 && node.data.CompareTo(i.next.data) <= 0)
                        {
                            node.next = i.next;
                            i.next = node;
                            break;
                        }
                    }
                }
                Length++;
            }
        }
        public void Add(T data, int m)
        {
            var node = new Node<T>(data);
            if (IsEmpty())
            {
                first = node;
                last = node;
                Length = 1;
                return;
            }
            else
            {
                node.next = first;
                first = node;
            }
            Length++;
        }
        public int IndexOf(T item)
        {
            var node = new Node<T>(item);
            int z = 0;
            for (Node<T> i = first; i != null; i = i.next)
            {
                if (node.data.Equals(i.data))
                {
                    return z;
                }
                z++;
            }
            return -1;
        }
        public void Deleteitem(T item)
        {
            if (Length == 1 && item.Equals(first))
            {
                first = null;
                last = null;
                Length = 0;
                return;
            }
            int p = IndexOf(item);
            if (p == 0)
            {
                first = first.next;
                Length--;
                return;
            }
            for (Node<T> i = first; i != null; i = i.next)
            {
                if (p == 1)
                {
                    if (i.next == last)
                    {
                        last = i;
                    }
                    i.next = i.next.next;
                    Length--;
                    return;
                }
                p--;
            }
        }
        public LinkedList<T> reverse_copy()
        {
            var L1 = new LinkedList<T>();
            for (Node<T> i = this.first; i != null; i = i.next)
            {
                L1.Add(i.data, 0);
            }
            return L1;
        }
    }
}
