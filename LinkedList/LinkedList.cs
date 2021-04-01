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
    }
}
