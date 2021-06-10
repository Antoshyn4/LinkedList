using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class Node<T>
    {
        public T data { get; set; }

        public Node<T> next { set; get; }

        public Node (T value)
        {
            data = value;
        }
        public Node (Node<T> node)
        {
            data = node.data;
            next = node.next;
        }
    }
}
