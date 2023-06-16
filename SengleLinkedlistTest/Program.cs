using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SengleLinkedlistTest
{

    internal class Program
    {
        static void Main(string[] args)
        {

            //The Question No. 6 in Big O == O(n)  Because of receiver function
            //The Question No. 7 in Big O == O(n)  Because of for loop

            LinkedList LList = new LinkedList();
            LList.Add(10);
            LList.Add(20);
            LList.Add(30);
            LList.Add(40);
            Node node1 = new Node();
            node1.data = 5;
            Node node2 = new Node();
            node2.data = 75;
            LList.InsertAt(55, 3);
            LList.Display();
            LList.InsertHead(node1);
            LList.InsertTail(node2);
            LList.Display();
            LList.RemovesFirstElement();
            LList.Display();
            LList.RemovesTail();
            LList.Display();
            LList.DisplayReverse();
            Console.WriteLine(LList.toString());
            //Console.WriteLine(LList.GetIndextOf(56));
            //LList.DisplayReverse();
            //Console.WriteLine();
            //LList.Display();
            //LList.RemoveAt(1);
            //LList.Display();
            //Console.Write("\t" + LList.Count());
            //LList.EmptyList();
            //LList.Display();
            //Console.WriteLine("\t" + LList.Count());
            //LList.Add(50);
            //LList.Add(60);
            //Console.WriteLine("\t" + LList.Count());
            //LList.Display();
            //Console.WriteLine("\t" + LList.Tail.data);
            Console.Read();


        }
    }
    public class Node
    {
        public Node Next = null;

        public int data;
    }
    public class LinkedList
    {
        public Node Head = null;

        public Node Tail = null;

        public Node Last()
        {
            Node LastNode;
            LastNode = Head;

            if (LastNode == null)
                return null;

            while (LastNode.Next != null)
            {
                LastNode = LastNode.Next;
            }
            return LastNode;
        }

        public void Add(int data)
        {
            Node node = new Node();
            node.data = data;
            if (Head == null)
            {
                Head = node;
            }
            else
            {
                Tail = node;
                Last().Next = node;
            }
        }
        //1. Write a  c# program to create and display a Singly Linked List.
        public void Display()
        {
            Node node = Head;
            if (node != null)
            {
                while (node.Next != null)
                {
                    Console.Write("\t" + node.data + "\t");
                    node = node.Next;
                }
                Console.WriteLine("\t" + node.data);
            }
            else
            {
                Console.WriteLine("\t  the list is Empty");
            }
        }
        ////10. Write a  c# program to empty a singly linked list by pointing the head towards null.
        public void EmptyList()
        {

            Head = null;
        }
        ////11. Write a  c# program that removes the node from the singly linked list at the specified index.
        public void RemoveAt(int xIndex)
        {
            int index = 0;
            Node node = Head;
            while (index != xIndex - 1)
            {
                node = node.Next;
                index++;
            }
            node.Next = node.Next.Next;
        }
        //12.Write a  c# program that calculates the size of a Singly Linked list.
        // 3. Write a  c# program to create a singly linked list of n nodes and count the number of nodes.
        public int Count()
        {
            int count = 0;
            Node node = Head;
            if (Head != null)
            {
                while (node.Next != null)
                {
                    count++;
                    node = node.Next;
                }
                count++;
            }
            return count;
        }
        // 2. Write a  c# program to create a singly linked list of n nodes and display it in reverse order.h
        public void DisplayReverse()
        {
            int[] array = ToArray();
            for (int i = Count() - 1; i >= 0; i--)
            {
                Console.Write("\t" + array[i] + "\t");
            }
        }
        // 4. Write a  c# program to insert a node at any position in a Singly Linked List.
        public void InsertAt(int Data , int Index)
        {
            int IndexC = 0; 
            Node node = Head;
            Node TempNode = new Node();   
            while (IndexC != Index-1)
            {
                node = node.Next;
                IndexC++;
            }
            TempNode.Next = node.Next;
            TempNode.data = Data;
            node.Next = TempNode;
        }
        //5. Write a  c# program to insert a node at the beginning of a Singly Linked List.
        public void InsertHead(Node node)
        {
            node.Next = Head;   
            Head = node;    
        }
        //6. Write a  c# program to insert a node at the end of a Singly Linked List.
        public void InsertTail(Node node)
        {
            Tail.Next = node;
            Tail = node;
        }
        //7. Write a  c# program to get a node in an existing singly linked list.
        public Node GetNodeAt() 
        {
            return Head;
        }
        //8. Write a  c# program to find the first index that matches a given element. Return -1 for no matching.
        public int GetIndextOf(int data)
        {
            int index = 0;  
            Node node = Head;   
            while (node.Next != null) 
            {
                if (node.data == data)
                {
                    return index;
                }
                index++;
                node = node.Next;
            }
            if (Tail.data == data) 
            {
                return index;
            }
            return -1;
        }

        //9. Write a  c# program to check whether a single linked list is empty or not. Return true othe rwise false.
        public bool IsEmpty()
        { 
            return Head == null ;
        }
        //13. Write a  c# program that removes the first element from a Singly Linked list.
        public void RemovesFirstElement() 
        {
           Head = Head.Next;
        }
        // 14. Write a  c# program that removes the tail element from a Singly Linked list.
        public void RemovesTail() 
        {
        Node node = Head;
            while (node.Next.Next != null)
            {
            node = node.Next;   
            }
            node.Next= null;
            Tail = node;
        }
        //15. Write a  c# program to convert a Singly Linked list into an array.
        public int[] ToArray()
        {
            if (Head==null)
            {
                return null;
            }
            int[] array = new int[this.Count()];
            int index = 0;
            Node node = Head;
            while (node.Next != null)
            {
                array[index++] = node.data;
                node = node.Next;
            }
            array[array.Length - 1] = node.data;
            return array;
        }
        // 16. Write a  c# program to convert a Singly Linked list into a string.
        public string toString() 
        {
            string theString = null;
            Node node = Head;
            while (node.Next != null)
            {
                theString = theString + node.data.ToString();
                node = node.Next;   
            }
            return theString + node.data.ToString();

        }

    }

}