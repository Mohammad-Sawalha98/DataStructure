using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class Program
    {
        public class Queue
        {
            public Queue Next;
            public Queue Prev;
            public int data;
            public Queue(int data = 0, Queue Next = null, Queue Prev = null)
            {
                this.data = data;
                this.Next = Next;
                this.Prev = Prev;
            }

        }

        public class Container
        {
            public Queue head;
            public Queue tail;
            public Queue queue;
            public Container()
            {
            }


            public void Enqueue(int value)
            {
                if (queue == null)
                {
                    queue = new Queue(value);
                    head = queue;
                    tail = queue;
                    queue.Next = null;
                    queue.Prev = null;
                }
                else
                {
                    while (queue.Next != null)
                    {
                    queue=queue.Next;
                    }

                    Queue newQueue = new Queue(value);
                    newQueue.Next = null;
                    newQueue.Prev = tail;
                    queue.Next = newQueue;
                    tail=newQueue;
                }
            }

            public void Dequeue()
            {
                if (queue == null)
                {
                    return;
                }
                else
                {
                    head = head.Next;
                }
            }

            public void print()
            {
                Queue temp = head;
                while (temp != null)
                {
                    Console.WriteLine(temp.data);
                    temp = temp.Next;
                }
            }
        }
            static void Main(string[] args)
            {
            Container container = new Container();
            container.Enqueue(1);
            container.Enqueue(2);
            container.Dequeue();
            container.Enqueue(3);
            container.Enqueue(4);
            container.Dequeue();
            container.print();
            }
        
    } 
}
