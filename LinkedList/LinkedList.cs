using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class LinkedList<T>
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
    }
}
