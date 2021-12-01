using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //LinkedList<string> _list = new LinkedList<string>();

            //_list.AddFirst("my");
            //_list.AddFirst("is");
            //_list.AddFirst("This");
            //_list.AddLast("Code");
            //_list.AddBefore(_list.First,"Look");
            //_list.AddFirst("aasajb");
            //_list.AddAfter(_list.Last, "Thank you!!");
            //_list.AddLast("nsjdgsd");
            //_list.RemoveFirst();
            //_list.RemoveLast();

            //foreach(var i in _list)
            //{
            //    Console.WriteLine(i);
            //}



            SinglyLinkedList<string> singlyLinkedList = new SinglyLinkedList<string>();

            InsertFront(singlyLinkedList, "the");
            InsertFront(singlyLinkedList, "fox");
            InsertFront(singlyLinkedList, "jumps");
            InsertFront(singlyLinkedList, "over");
            InsertFront(singlyLinkedList, "the");
            InsertFront(singlyLinkedList, "dog");

            InsertLast(singlyLinkedList, "the");
            InsertLast(singlyLinkedList, "fox");
            InsertLast(singlyLinkedList, "jumps");
            InsertLast(singlyLinkedList, "over");
            InsertLast(singlyLinkedList, "the");
            InsertLast(singlyLinkedList, "dog");

            InsertAfter(singlyLinkedList, "the");
            InsertAfter(singlyLinkedList, "fox");
            InsertAfter(singlyLinkedList, "jumps");
            InsertAfter(singlyLinkedList, "over");
            InsertAfter(singlyLinkedList, "the");
            InsertAfter(singlyLinkedList, "dog");

            InsertBefore(singlyLinkedList, "the");
            InsertBefore(singlyLinkedList, "fox");
            InsertBefore(singlyLinkedList, "jumps");
            InsertBefore(singlyLinkedList, "over");
            InsertBefore(singlyLinkedList, "the");
            InsertBefore(singlyLinkedList, "dog");

            DoublyLinkedList<string> doublyLinkedList = new DoublyLinkedList<string>();

            InsertFront(doublyLinkedList, "the");
            InsertFront(doublyLinkedList, "dog");
            InsertFront(doublyLinkedList, "jumps");
            InsertFront(doublyLinkedList, "over");
            InsertFront(doublyLinkedList, "the");
            InsertFront(doublyLinkedList, "fox");

            InsertLast(doublyLinkedList, "the");
            InsertLast(doublyLinkedList, "dog");
            InsertLast(doublyLinkedList, "jumps");
            InsertLast(doublyLinkedList, "over");
            InsertLast(doublyLinkedList, "the");
            InsertLast(doublyLinkedList, "fox");
            
            InsertAfter(doublyLinkedList, "the");
            InsertAfter(doublyLinkedList, "dog");
            InsertAfter(doublyLinkedList, "jumps");
            InsertAfter(doublyLinkedList, "over");
            InsertAfter(doublyLinkedList, "the");
            InsertAfter(doublyLinkedList, "fox");

            InsertBefore(doublyLinkedList, "the");
            InsertBefore(doublyLinkedList, "dog");
            InsertBefore(doublyLinkedList, "jumps");
            InsertBefore(doublyLinkedList, "over");
            InsertBefore(doublyLinkedList, "the");
            InsertBefore(doublyLinkedList, "fox");
        }


        public static void InsertBefore<T>(SinglyLinkedList<T> singlyList,T new_data)
        {
            if (singlyList == null)
            {
                Console.WriteLine("The given previous node Cannot be null");
                return;
            }
            Node<object> new_nodes = new Node<object>(new_data);
            new_nodes.next = singlyList.next;
            singlyList.next = new_nodes;
            
        }
        public static void InsertBefore<T>(DoublyLinkedList<T> doublyList, T new_Data)
        {
            if (doublyList == null)
            {
                Console.WriteLine("The given previous node Cannot be null");
                return;
            }
            DNode<object> new_node = new DNode<object>(new_Data);
            new_node.next = doublyList.next;
            doublyList.next = new_node;
            new_node.prev = doublyList.prev;
            doublyList.prev = new_node;

        }
        public static void InsertAfter<T>(SinglyLinkedList<T> singlyLinkedList, T new_data)
        {
            if (singlyLinkedList == null)
            {
                Console.WriteLine("The given previous node Cannot be null");
                return;
            }
            Node<object> new_node = new Node<object>(new_data);
            new_node.next = singlyLinkedList.next;
            singlyLinkedList.next = new_node;
        }
        public static void InsertAfter<T>(DoublyLinkedList<T> doublyLinkedList, T data)
        {
            if (doublyLinkedList == null)
            {
                Console.WriteLine("The given prevoius node cannot be null");
                return;
            }
            DNode<object> newNode = new DNode<object>(data);
            newNode.next = doublyLinkedList.next;
            doublyLinkedList.next = newNode;
            newNode.prev = doublyLinkedList.prev;
            if (newNode.next != null)
            {
                newNode.next.prev = newNode;
            }
        }

        public static void InsertLast<T>(SinglyLinkedList<T> singlyList, T new_data)
        {
            Node<T> new_node = new Node<T>(new_data);
            if (singlyList.head == null)
            {
                singlyList.head = new_node;
                return;
            }
            Node<T> lastNode = GetLastNode(singlyList);
            lastNode.next = new_node;
        }
        public static void InsertLast<T>(DoublyLinkedList<T> doublyLinkedList, T data)
        {
            DNode<T> newNode = new DNode<T>(data);
            if (doublyLinkedList.head == null)
            {
                newNode.prev = null;
                doublyLinkedList.head = newNode;
                return;
            }
            DNode<T> lastNode = GetLastNode(doublyLinkedList);
            lastNode.next = newNode;
            newNode.prev = lastNode;
        }

        public static void InsertFront<T>(SinglyLinkedList<T> singlyList, T new_data)
        {
            Node<T> new_node = new Node<T>(new_data);
            new_node.next = singlyList.head;
            singlyList.head = new_node;
        }
        public static void InsertFront<T>(DoublyLinkedList<T> doubleLinkedList, T data)
        {
            DNode<T> newNode = new DNode<T>(data);
            newNode.next = doubleLinkedList.head;
            newNode.prev = null;
            if (doubleLinkedList.head != null)
            {
                doubleLinkedList.head.prev = newNode;
            }
            doubleLinkedList.head = newNode;
        }

        private static Node<T> GetLastNode<T>(SinglyLinkedList<T> singlyList)
        {
            Node<T> temp = singlyList.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }
        private static DNode<T> GetLastNode<T>(DoublyLinkedList<T> doublyList)
        {
            DNode<T> temp = doublyList.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }


        internal class SinglyLinkedList<T>
        {
            internal Node<T> head;
            internal Node<object> next;
            internal Node<object> prev;
        }
        internal class DoublyLinkedList<T>
        {

            internal DNode<T> head;
            internal DNode<object> prev;
            internal DNode<object> next;
            
        }
       
        internal class Node<T>
        {
            internal T data;
            internal Node<T> next;
            internal Node<T> prev;
            public Node(T value)
            {
                data = value;
                next = null;
                prev = null;
            }
        }
        internal class DNode<T>
        {
            internal T data;
            internal DNode<T> prev;
            internal DNode<T> next;

            public DNode(T value)
            {
                data = value;
                prev = null;
                next = null;
            }
        }
    }
}

