using System;

namespace ЛинкдЛист
{
    internal class Program
    {
        static void Main(string[] args)
        
        
        {
            ImStarNode<string> list = new ImStarNode<string>();
            list.Add("breakfast");
            list.Add("lunch");
            list.Add("dinner");
            list.Loop();

            Console.WriteLine("==========");

            ImStarNode<string> list3 = new ImStarNode<string>();
            list3.Add("breakfast");
            list3.Add("lunch");
            list3.Add("dinner");
            list3.Remove(2);
            list3.Loop();
            Console.WriteLine("==========");
            ImStarNode<int> list2 = new ImStarNode<int>();
            list2.Add(3);
            list2.Loop();
            
        }
    }
    class Node<T>
    {
        public object Data { get; set; }
        public Node<T> Next { get; set; }
    }

    class ImStarNode<T>
    {
        public Node<T> Head { get; set; }
        public void Add(T data)
        {
            if(Head == null)
            {
                Head = new Node<T>() { Data = data };
            }
            else
            {
                Node<T> current = Head;
                while(current.Next != null)
                    {
                        current = current.Next;
                    }
                current.Next = new Node<T>() { Data = data };
            }
        }

        public bool Remove(int nodeN)
        {
            bool removed = false;

            Node<T> current = this.Head;
            Node<T> prev = null;

            int x = 0;
            while (x < nodeN && current != null)
            {
                prev = current;
                current = current.Next;

                x++;
            }

            if (current != null)
            {
                if (prev == null)
                {
                    this.Head = current.Next;
                }
                else
                {
                    prev.Next = current.Next;
                    current = null;
                }

                current = null;
                removed = true;
            }

            return removed;
        }

        public void Loop()
        {
            Node<T> current = Head;
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }
    }

}
