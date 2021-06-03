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
            current = head;
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                while(true)
                    {
                        if(current = null)
                        {
                            current = newNode;
                        break;
                        }
                        current = current.Next;
                    }
            }

            count++;

        }

        public override void Add(int Position, T data)
        {
            Node newNode = new Node(data);
            current = head;
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                int pos = 0;
                while(true)
                    {
                    
                        if(current = pos)
                        {
                            current = newNode;
                        break;
                        }
                        current = current.Next;
                    pos++;
                    }
            }

            count++;
        }

        public override void Clear()
        {
            head = null;
        }

        public override T ElementAt(int Position)
        {
            current = head;
            if (Position < 0 || Position >= count) 
                throw new IndexOutOfRangeException();

            current = head;
            int pos = 0;
            while (current.Next != null)
            {
                if(pos = Position)
                    {
                        return current;
                    }
                current = current.Next;
                pos++;
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
            current = head;
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
