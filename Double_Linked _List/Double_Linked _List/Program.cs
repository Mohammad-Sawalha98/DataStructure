using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Double_Linked_List
{

    public class Node
    {
        public int data;
        public Node Next;
        public Node Prev;

        public Node(int data, Node Next = null, Node Prev = null )
            {
            this.data = data;
            this.Next = Next;
            this.Prev = Prev;  
            }
    }

    public class LinkedList
    {
        public Node head = null;
        public Node tail = null;
        public Node node = null;
        int pos = 0;

        public LinkedList() { }


        public void append(int value)
        {
            if(node == null)
            {
                node = new Node(value);
                head = node;
                tail = node;
                node.Prev = null;
                node.Next = null;
            }
            else
            {
                while(node.Next != null)
                {
                    node=node.Next;
                }

                Node newNode= new Node(value);
                node.Next = newNode;
                newNode.Prev = tail;
                tail= newNode;
            }

        }

        public void appendAfter(int value, int addAfter)
        {
            Node tempHead = this.head; 
            if (tempHead != null)

                while (tempHead != null)
                {

                    if(tempHead.data == addAfter)
                    {
                        Node newNode = new Node(value);
                        newNode.Prev= tempHead;
                        newNode.Next = tempHead.Next;
                        tempHead.Next = newNode;
                        return;

                    }
                    else
                    {
                       tempHead= tempHead.Next;
                    }


                }
            else
            {
                Console.WriteLine("thre are no node defined");
            }
          
        }


        public void Search(int value)
        {
            Node start = this.head;
        if (start != null)
            {
                pos = 0;
                while (start != null)
                {
                    pos++;
                    if (start.data == value)
                    {
                        Console.WriteLine("The position of your node is : " + pos);
                        return;
                    }
                    else
                    {
                        start= start.Next;
                    }
                   
                }
               
            }

        }


        public void print()
        {
            Node temp = head;
            while (temp != null)
            {
                pos++;
                Console.WriteLine("the posision of node " + (temp.data) + (" is ") + (pos));
                temp = temp.Next;            
                
            }

        }

        public void printRevese()
        {
            Node temp = tail;
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.Prev;

            }

        }
    }


    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            linkedList.append(1);
            linkedList.append(2);
            linkedList.append(3);
            linkedList.appendAfter(10, 2);
            linkedList.print();
            linkedList.Search(10);
        }
    }
}
