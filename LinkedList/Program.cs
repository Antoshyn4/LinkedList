using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new LinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(10);
            list.Add(3);
            list.Add(-1);
            list.Add(12);
            list.Deleteitem(12);
            list.Print();
            var L1 = new LinkedList<int>();
            L1 = list.reverse_copy();
            L1.Print();
        }
    }
}
