using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverList
{
    public class RoverList<T> : RoverListBase<T>
    {
        // Add any variables you need here
        private int count;
        public RoverList ()
        {
            count = 0; 
        }

        public override int Count
        {
            get
            {
                return count;
            }
        }

        public override void Add(T data)
        {
            Node newNode = new Node(data);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                throw new EntryPointNotFoundException();
            }

            count++;

        }

        public override void Add(int Position, T data)
        {
            throw new IndexOutOfRangeException ();
        }

        public override void Clear()
        {
            head = null;
        }

        public override T ElementAt(int Position)
        {
            if (Position < 0 || Position >= count) 
                throw new IndexOutOfRangeException();

            current = head;

            while (current.Next != null)
            {
                current = current.Next;
            }

            return default(T);
        }

        public override void ListNodes()
        {
            current = head;
            while (current != null)
                {
                    Console.WriteLine(current.Data + " ,");
                }
        }

        public override bool RemoveAt(int Position)
        {
            bool removed = false;
            if (Position == 0)
            {
                head = head.Next;
            }
            else
            {
               
                current.Next = current.Next.Next;

            }
            return removed;
        }
    }
}
