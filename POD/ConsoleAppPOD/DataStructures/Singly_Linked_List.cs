using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPOD.DataStructures
{
    public class Node<T>
    {
        public T data { get; set; }
        public Node<T> next { get; internal set; }
        public Node(T data)
        {
            this.data = data;
        }
    }

    public class LinkedList<T>
    {
        public Node<T> first { get; private set; }
        public Node<T> last { get; private set; }
        public int count { get; set; }
        public LinkedList()
        {
            this.first = null;
            this.last = null;
        }

        public void AddFirst(Node<T> newNode)
        {
            if (this.first == null)
            {
                //linkedlist is empty. insert new node head and tail
                this.first = newNode;
                this.last = newNode;
            }
            else
            {
                newNode.next = this.first;
                this.first = newNode;
            }

            count++;
        }

        public void AddLast(Node<T> newNode)
        {
            if (this.first == null)
            {
                //linkedlist is empty. insert new node head and tail
                this.first = newNode;
                this.last = newNode;
            }
            else
            {
                this.last.next = newNode;
                last = newNode;
            }

            count++;
        }

        public void AddAfter(Node<T> newNode, Node<T> existingNode)
        {
            //adding after last node , then need to repoint last pointer
            if (this.last == null)
                last = newNode;

            newNode.next = existingNode.next;
            existingNode.next = newNode;
            this.count++;
        }

        public Node<T> Find(T target)
        {
            Node<T> currentNode = first;

            while (currentNode != null && !currentNode.data.Equals(target))
            {
                currentNode = currentNode.next;
            }

            return currentNode;
        }

        public void RemoveFirst()
        {
            if (first == null || this.count == 0)
            {
                //nothing to do
                return;
            }

            first = first.next;
            this.count--;
        }

        public void Remove(Node<T> doomedNode)
        {
            if (first == null || this.count == 0)
            {
                return;
            }

            if (this.first == doomedNode)
            {
                RemoveFirst();
                return;
            }

            //else need to travel linkedlist to find doomednode and remove it

            Node<T> previous = first;
            Node<T> current = previous.next;

            while (current != null && current != doomedNode)
            {
                //move to next node
                previous = current;
                current = previous.next;
            }

            //remove it
            if (current != null)
            {
                previous.next = current.next;
                this.count--;
            }
        }

        public void Traversal()
        {
            Console.WriteLine("\nFirst " + this.first.data);
            Console.WriteLine("Last " + this.last.data);

            Node<T> node = this.first;

            while (node.next != null)
            {
                Console.WriteLine(node.data);
                node = node.next;
            }

            Console.WriteLine(node.data);
        }
    }

    public class Singly_Linked_List
    {
        public static void SinglyLinkedList()
        {

            LinkedList<string> ll = new LinkedList<string>();

            Node<string> a = new Node<string>("noor");
            ll.AddFirst(a);

            Node<string> b = new Node<string>("roon");
            ll.AddFirst(b);

            Node<string> c = new Node<string>("park");
            ll.AddFirst(c);

            Node<string> d = new Node<string>("mark");
            ll.AddFirst(d);

            ll.Traversal();

            Console.WriteLine("Add after roon");
            ll.AddAfter(new Node<string>("elon"), b);
            ll.Traversal();

            Node<string> target = ll.Find("roon");
            if (target != null)
            {
                Console.WriteLine("found: " + target.data);
            }
            else
            {
                Console.WriteLine("foorbar");
            }

            Console.WriteLine("\nremoving " + target.data);
            ll.Remove(target);
            ll.Traversal();
        }
    }
}
