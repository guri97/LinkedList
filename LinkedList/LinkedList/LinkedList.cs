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
        //uc1,uc5 and uc6(print)
        internal void Display()
        {
            Node temp = Head;
            if (temp == null)
                Console.WriteLine("Linked list is empty");
            else
                Console.Write("Linked list");
            while (temp != null)
            {
                Console.Write(temp.data);
                if (temp.next != null)
                    Console.Write("->");
                temp = temp.next;
            }
        }
        //uc2
        public void AddatFirst(int element)
        {
            Node newnode = new Node(element);
            newnode.next = Head;
            Head = newnode;



        }
        //uc3
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
        //this is to print for the both uc2 and uc3
        public void printList()
        {
            Node tnode = Head;
            while (tnode != null)
            {
                Console.Write(tnode.data + "->");
                tnode = tnode.next;
            }
        }
        //uc4
        public void InsertAtMid(int element)
        {
            if (Head == null)
                Head = new Node(element);
            else
            {
                Node newNode = new Node(element);
                Node pointer1 = Head;
                Node pointer2 = Head.next;
                while (pointer2 != null && pointer2.next != null)
                {
                    pointer1 = pointer1.next;
                    pointer2 = pointer2.next.next;
                }
                newNode.next = pointer1.next;
                pointer1.next = newNode;
            }


        }
        //print uc4
        public void Display1()
        {
            Node temp = Head;
            while (temp != null)
            {
                Console.Write(temp.data + "->");
                temp = temp.next;
            }
        }
        //uc5
        public void removeFront()//deletingNodeAtFirst
        {
            if (this.Head != null)
            {
                Node temp = this.Head;
                this.Head = this.Head.next;
                temp = null;
            }
        }
        public void DeletingNodeAtEnd()
        {
            if (this.Head != null)
            {
                if (this.Head.next == null)
                {
                    this.Head = null;
                }
                else
                {
                    Node temp = this.Head;

                    while (temp.next.next != null)
                        temp = temp.next;
                    Node lastNode = temp.next;
                    temp.next = null;
                    lastNode = null;
                }
            }
        }


    }
}