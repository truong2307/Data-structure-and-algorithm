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
    }
}
