using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoublyLinkedListApp
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    public class Node
    {
        public int Data;
        public Node Next;
        public Node Previous;

        public Node(int data)
        {
            Data = data;
            Next = null;
            Previous = null;
        }
    }

    public class DoublyLinkedList
    {
        private Node head;

        public void AddToFront(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                newNode.Next = head;
                head.Previous = newNode;
                head = newNode;
            }
        }

        public void Delete(int data)
        {
            Node current = head;
            while (current != null)
            {
                if (current.Data == data)
                {
                    if (current.Previous != null)
                        current.Previous.Next = current.Next;
                    if (current.Next != null)
                        current.Next.Previous = current.Previous;

                    if (current == head) // Если удаляем голову
                        head = current.Next;

                    return;
                }
                current = current.Next;
            }
        }

        public List<int> ToList()
        {
            List<int> result = new List<int>();
            Node current = head;
            while (current != null)
            {
                result.Add(current.Data);
                current = current.Next;
            }
            return result;
        }
    }
    }
