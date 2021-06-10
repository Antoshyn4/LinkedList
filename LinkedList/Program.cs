using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new LinkedList<int>();
            list.Add(999, 1);
            list.Add(1, 1);
            list.Add(2, 1);
            list.Add(227, 1);
            list.Add(3, 1);
            list.Add(4, 1);
            list.Add(-7, 1);
            list.Add(5, 1);
            list.Add(17, 1);
            list.Add(6,1);
            list.Add(7,1);
            list.Add(7111, 1);
            list.Print();
            Console.WriteLine();
            //list.z(3);
            list.bubblesort();
            list.Print();
        }
    }
}
