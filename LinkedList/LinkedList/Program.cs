namespace LinkedList
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Linkedlist linked = new Linkedlist();
            Node node1 = new Node(70);
            //linked.AddNode(node1);
            Node node2 = new Node(56);
            //linked.AddNode(node2);
            Node node3 = new Node(30);
            //linked.AddNode(node3);
            //linked.Display();
            //uc2
            //linked.AddatFirst(70);
            //linked.AddatFirst(30);
            //linked.AddatFirst(56);
            //uc3
            //linked.append(56);
            //linked.append(30);
            //linked.append(70);

            //pritn uc2 and 3
            //linked.printList();
            //uc4
            //linked.Head = null;
            //linked.Head = new Node(56);
            //linked.Head.next = new Node(70);
            //Console.WriteLine("Linked list before" + "insertion:");
            //linked.Display1();
            //linked.InsertAtMid(30);
            //Console.WriteLine("\nlinkedlist after "+"insertion:");
            //linked.Display1();
            //uc5
            linked.AddNode(node3);
            linked.AddNode(node2);
            linked.AddNode(node1);
            //Console.Write("Delete first element");
            //linked.removeFront();
            Console.Write("Delete last element");
            linked.DeletingNodeAtEnd();
            linked.Display();






        }
    }
}