using System;

namespace HomeWork4
{
    class Program
    {
        public class Node<T>
        {
            public Node<T> Next { get; set; }
            public T Data { get; set; }
            public Node(T t) {
                Next = null;
                Data = t;
            }
        }
        public class GenericList<T>
        {
            private Node<T> head;
            private Node<T> tail;
            public Node<T> Head { get { return head; } }
            public GenericList()
            {
                head = tail = null;
            }
            public void Add(T t) 
            {
                Node<T> node = new Node<T>(t);
                if (tail == null)
                {
                    head = tail = node;
                }
                else
               {
                    tail.Next = node;
                    tail = node;
                }
            }
        }
        delegate  int Func(int x);
        static int ForEachList(GenericList<int> t, Func func)
        {
            int n = 0;
            if (t.Head != null)
            {
                while (t.Head.Next != null)
                {
                    func(t.Head.Data);
                    t.Head.Next = t.Head;
                }
                return n;
            }
            else {
                throw new Exception("空指针异常");
            }
        }
        static void Main(string[] args)
        {
            GenericList<int> g = new GenericList<int>();
            for(int i = 0; i < 5; i++)
            {
                g.Add(i);
            }
            int sum = 0;
            ForEachList(g, x => sum += x);
            int?max = 0;
            ForEachList(g, x => { if (max == null) { max = x; } else { max = max > x ? max : x; } return (int)max; });
            int?min = 0;
            ForEachList(g, x => { if (min == null) { min = x; } else { min = min > x ? min : x; } return (int)min; });
        }
    }
}
