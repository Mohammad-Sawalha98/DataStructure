using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class Program
    {
        public class Stack
        {
            public int data;
            public Stack Next;
            public Stack Prev;
            public Stack(int data  , Stack Next=null , Stack Prev = null ) 
            {
                this.data = data;
                this.Next = Next;
                this.Prev = Prev;
            }
        }


        public class Container
        {
            public Stack head;
            public Stack tail;
            public Stack stack;

            public Container() { }  

            public void push(int value)
            { 
                if (stack == null)
                {
                   stack = new Stack(value);
                    head = stack;
                    tail = stack;
                    stack.Next = null;
                    stack.Prev = null;
                }
                else
                {
                    while (stack.Prev != null)
                    {
                        stack=stack.Prev;
                    }
                    Stack newStack = new Stack(value);
                    newStack.Next = null;
                    newStack.Prev=tail;
                    tail = newStack;
                }
            
            }

            public void pop(int value)
            {
                if (stack == null)
                {
                    return;
                }
                else
                {                  
                    if(tail.data == value)
                    {
                        tail = tail.Prev;
                    }
                }
            }


            public void print()
            {
                Stack temp = tail;
            while(temp != null)
                {
                    Console.WriteLine(temp.data);
                    temp=temp.Prev;
                }
            }


        }




        static void Main(string[] args)
        {
            Container container = new Container();
           container.push(1);
           container.push(2);
           container.push(3);
           container.push(4);
           container.pop(4);
           container.pop(3);
           //container.pop(2);
           //container.pop(1);
            container.print();
        }
    }
}
