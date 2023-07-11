using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List
{

    public class Node
    {
        public Node next;
        public int data;
        public Node(int data, Node next= null) { this.data = data; this.next = next; }

    }
    public class linkedlist
    {
        public Node node =  null; 
        public Node head = null;
        public linkedlist() 
        {
       
        }

        public void append(int value)
        {
            if(node == null)
            {
                node = new Node(value);
                head = node;
            }
            else
            {
                while(node.next != null) {
                    node= node.next;
                }

                Node newNode = new Node(value);
                node.next= newNode;

            }
        }

        public void print()
        {   Node temp = head;
            while (temp != null) { Console.WriteLine(temp.data); temp=temp.next; }
            //Node node = ( new Node();
            //node = this.head;
           
            //ifnode!= null)
            //{
            //    Console.WriteLine("The list contains:");

            //    while (node!= null)
            //    {
            //        Console.WriteLine(node.data + " ");
            //        node = node.next;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("The list is empty");
            //}

        }

    }

   
   
    public class Program
    {
        //public void InsertFront(singleLinkedlist singleList, int newData)
        //{
        //    Node node = new Node();
        //    node.next = singleList.head;
        //    singleList.head = node;
        //}

        //public void InsertEnd (singleLinkedlist singleList, int newData)
        //{
        //    Node node = new Node();
        //    node.next = null;
        //    singleList.head = node;
        //}
        static void Main(string[] args)
        {
            linkedlist linkedList = new linkedlist();
            linkedList.append(1);
            linkedList.append(2);
            linkedList.append(3);
            linkedList.append(4);
            linkedList.print();
            //singleLinkedlist linkedlist = new singleLinkedlist();

            //Node first = new Node();
            //first.data= 1;
            //first.next = null;
            //linkedlist.head= first;

            //Node second = new Node();
            //second.data= 2;
            //second.next = null;
            //first.next = second;

            //Node third = new Node();
            //third.data= 3;
            //third.next = null;
            //second.next = third;

            //linkedlist.printLinkedlist();

        }
    }
}
