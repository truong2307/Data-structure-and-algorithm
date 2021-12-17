using System;

namespace manageCarr.DoublyLinkedList
{
    public static class DoublyLinkedList
    {
        public class Node
        {
            public int value { get; set; }
            public Node Next { get; set; }
            public Node Previous { get; set; }
        }

        public class DoubleLinkedList
        {        
            public Node Head { get; set; }
            public Node Tail { get; set; }
        }

        private static Node CreateNode(int valueRequest)
        {
            Node nodeCreate = new Node
            {
                value = valueRequest,
                Next = null,
                Previous = null
            };

            return nodeCreate;
        }

        public static void AddFirstNode(this DoubleLinkedList node, int valueRequest)
        {
            Node newNode = CreateNode(valueRequest);
            if (node.Head == null)
            {
                node.Tail = node.Head = newNode;
            }
            else
            {
                newNode.Next = node.Head;
                node.Head.Previous = newNode;
                node.Head = newNode;
            }
        }

        public static void AddLastNode(this DoubleLinkedList node, int valueRequest)
        {
            Node newNode = CreateNode(valueRequest);
            if (node.Head == null)
            {
                node.Tail = node.Head = newNode;
            }
            else
            {
                newNode.Previous = node.Tail;
                node.Tail.Next = newNode;
                node.Tail = newNode;
            }
        }

        public static void AddAfterNode(this DoubleLinkedList node, int valueAfter, int valueRequest)
        {
            Node myNode = node.Head;
            while (myNode != null && myNode.value != valueAfter)
            {
                myNode = myNode.Next;
            }

            if (myNode != null)
            {
                if (myNode != node.Tail)
                {
                    Node newNode = CreateNode(valueRequest);

                    newNode.Next = myNode.Next;
                    myNode.Next.Previous = newNode;

                    newNode.Previous = myNode;
                    myNode.Next = newNode;
                }
                else
                {
                    AddLastNode(node, valueRequest);
                }
            }
        }

        public static void DisplayNodeLeftToRight(this DoubleLinkedList node)
        {
            Node newNode = node.Head;
            while (newNode !=null )
            {
                Console.Write(newNode.value +" ");
                newNode = newNode.Next;
            }
        }

        public static void DisplayNodeRightToLeft(this DoubleLinkedList node)
        {
            Node newNode = node.Tail;
            while (newNode != null)
            {
                Console.Write(newNode.value + " ");
                newNode = newNode.Previous;
            }
        }

    }
}
