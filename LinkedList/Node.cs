using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class Node<T>
    {
        public T data { get; }

        public Node<T> next { set; get; }

        public Node (T value)
        {
            data = value;
        }

    }
}
