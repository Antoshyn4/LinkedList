using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class Node<T>
    {
        private T data { set; get; }

        private Node<T> next { set; get; }
    }
}
