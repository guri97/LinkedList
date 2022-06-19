using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Linkedlist
    {
        public Node Head;
        public Node Tail;
        public Linkedlist()
        {
            Head = null;
            Tail = null;
        }
        public void AddNode(Node node)
        {
            if (Head == null && Tail == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                node.next = Head;
                Head = node;
            }

        }
        //internal void Display()
        //{
        //    Node temp = Head;
        //    if (temp == null)
        //        Console.WriteLine("Linked list is empty");
        //    else
        //        Console.WriteLine("Linked list");
        //    while (temp != null)
        //    {
        //        Console.WriteLine(temp.data);
        //        if (temp.next != null)
        //            Console.WriteLine(">");
        //        temp = temp.next;
        //    }
        //}
        public void AddatFirst(int element)
        {
            Node newnode = new Node(element);
            newnode.next = Head;
            Head = newnode;



        }
        public void append(int newdata)
        {
            Node new_node = new Node(newdata);
            if (Head == null)
            {
                Head = new Node(newdata);
                return;
            }
            new_node.next = null;
            Node last = Head;
            while (last.next != null)
                last = last.next;
            last.next = new_node;
            return;


        }
        public void printList()
        {
            Node tnode = Head;
            while (tnode != null)
            {
                Console.WriteLine(tnode.data + " ");
                tnode = tnode.next;
            }
        }
    }
}