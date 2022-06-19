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
            //linked.AddatFirst(70);
            //linked.AddatFirst(30);
            //linked.AddatFirst(56);
            linked.append(56);
            linked.append(30);
            linked.append(70);


            linked.printList();


        }
    }
}