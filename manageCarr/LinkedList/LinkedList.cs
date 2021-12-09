using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manageCarr.LinkedList
{
    public static class LinkedList
    {
        public class Node
        {
            public int Value { get; set; }
            public Node Next { get; set; }
            public Node()
            {
            }
        }

        private static Node CreateNode (int value)
        {
            Node node = new Node
            {
                Value = value,
                Next = null
            };
            return node;
        }

        public static void InsertLastNode(this Node head, int value)
        {
            Node newNode = head;
            Node parent = null;

            if (newNode.Value == 0)
            {
                newNode.Value = value;
            }
            else
            {
                while (newNode != null && newNode.Value != value)
                {
                    parent = newNode;
                    newNode = newNode.Next;
                }
            }

            if (newNode == null)
            {
                newNode = CreateNode(value);
                parent.Next = newNode;
            }
        }

        public static Node InsertFirstNode(this Node node, int value)
        {
            Node newNode = CreateNode(value);
            newNode.Next = node;

            return newNode;
        }

        public static void InsertAfterNode(this Node node, int valueOfNodeAfter, int value)
        {
            Node newNode = CreateNode(value);
            Node myNode = node;

            while (myNode != null && myNode.Value != valueOfNodeAfter && myNode.Value != value)
            {
                myNode = myNode.Next;
            }

            if (myNode != null)
            {
                newNode.Next = myNode.Next;
                myNode.Next = newNode;
            }
        }

        public static void DisplayNode (this Node node)
        {
            Node newNode = node;
            while (newNode != null)
            {
                Console.Write(newNode.Value + " ");
                newNode = newNode.Next;
            }
        }

        public static Node DeleteFirstNode (this Node head)
        {
            if (head != null)
            {
                Node newNode = head.Next;
                return newNode;
            }

            throw new Exception(); 
        }

        public static void DeleteLastNode(this Node node)
        { 
            if (node != null)
            {
                Node lastNode = node;
                Node parent = null;

                while (lastNode.Next != null)
                {
                    parent = lastNode;
                    lastNode = lastNode.Next;
                }
                if (parent == null)
                {
                    Console.WriteLine(DeleteFirstNode(node));
                }
                else
                {
                    parent.Next = null;
                }
            }
            else
            {
                throw new Exception();
            }
        }

        public static void DeleteNodeValue(this Node node, int valueRequest)
        {
            if (node != null)
            {
                Node newNode = node;
                Node parent = null;
                while (newNode != null && newNode.Value != valueRequest)
                {
                    parent = newNode;
                    newNode = newNode.Next;
                }

                if (newNode != null)
                {
                    if (parent == null)
                    {
                        Node deleted = DeleteFirstNode(node);
                        DisplayNode(deleted);
                    }
                    else
                    {
                        parent.Next = parent.Next.Next;
                    }
                }
            }
            else
            {
                throw new Exception();
            }
        }

    }
}
