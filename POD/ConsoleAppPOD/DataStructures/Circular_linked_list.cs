using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPOD.DataStructures
{
    //node structure
    public class CircularNode
    {
        public int data;
        public CircularNode next;
    }

    public class CircularLinkedList
    {
        public CircularNode head;
        //constructor to create an empty LinkedList
        public CircularLinkedList()
        {
            head = null;
        }

        //display the content of the list
        public void PrintList()
        {
            CircularNode temp = new CircularNode();
            temp = this.head;
            if (temp != null)
            {
                Console.Write("The list contains: ");
                while (true)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                    if (temp == this.head)
                        break;
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("The list is empty.");
            }
        }
    }

    public class Circular_linked_list
    {
        //https://www.alphacodingskills.com/cs/ds/cs-circular-singly-linked-list.php
        public static void MainProgram()
        {
            //create an empty LinkedList
            CircularLinkedList MyList = new CircularLinkedList();

            //Add first node.
            CircularNode first = new CircularNode();
            first.data = 10;
            //linking with head node
            MyList.head = first;
            //linking next of the node with head
            first.next = MyList.head;

            //Add second node.
            CircularNode second = new CircularNode();
            second.data = 20;
            //linking with first node
            first.next = second;
            //linking next of the node with head
            second.next = MyList.head;

            //Add third node.
            CircularNode third = new CircularNode();
            third.data = 30;
            //linking with second node
            second.next = third;
            //linking next of the node with head
            third.next = MyList.head;

            //print the content of list
            MyList.PrintList();
        }
    }
}
