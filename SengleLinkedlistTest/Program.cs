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
            LinkedList LList = new LinkedList();
            LList.Add(10);
            LList.Add(20);
            LList.Add(30);
            LList.Add(40);
            LList.Display();
            //11. Write a  c# program that removes the node from the singly linked list at the specified index.
            LList.RemoveAt(1);
            LList.Display();
            Console.Write("\t" + LList.Count());
            //10. Write a  c# program to empty a singly linked list by pointing the head towards null.
            LList.EmptyList();
            LList.Display();
            //12.Write a  c# program that calculates the size of a Singly Linked list.

            Console.WriteLine("\t" + LList.Count());
            LList.Add(50);
            LList.Add(60);
            Console.WriteLine("\t" + LList.Count());
            LList.Display();
            Console.WriteLine("\t" + LList.Tail.data);
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

        public Node First()
        {
            return Head;
        }

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
        public void EmptyList()
        {

            Head = null;
        }

        public void RemoveAt(int x)
        {
            int index = 0;
            Node node = Head;
            while (index != x - 1)
            {
                node = node.Next;
                index++;
            }
            node.Next = node.Next.Next;
        }
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

    }

}