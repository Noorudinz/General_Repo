using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPOD.DataStructures
{
    //node structure
    class Node
    {
        public int data;
        public Node next;
        public Node prev;
    };

    class LinkedList
    {
        public Node head;
        //constructor to create an empty LinkedList
        public LinkedList()
        {
            head = null;
        }

        //display the content of the list
        public void PrintList()
        {
            Node temp = new Node();
            temp = this.head;
            if (temp != null)
            {
                Console.Write("The list contains: ");
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("The list is empty.");
            }
        }
    }

    public class Doubly_Linked_List
    {
        //https://www.alphacodingskills.com/cs/ds/cs-doubly-linked-list.php
        public static void MainProgram()
        {
            //create an empty LinkedList 
            LinkedList MyList = new LinkedList();

            //Add first node.
            Node first = new Node();
            first.data = 10;
            first.next = null;
            first.prev = null;
            //linking with head node
            MyList.head = first;

            //Add second node.
            Node second = new Node();
            second.data = 20;
            second.next = null;
            //linking with first node
            second.prev = first;
            first.next = second;

            //Add third node.
            Node third = new Node();
            third.data = 30;
            third.next = null;
            //linking with second node
            third.prev = second;
            second.next = third;

            //print the content of list
            MyList.PrintList();
        }
      
    }
}
