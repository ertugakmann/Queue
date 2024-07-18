using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Queues
    {
        private Node head;
        private Node tail;
        private int size;

        public Queues()
        {
            head = null;
            tail = null;
            size = 0;
        }

        public Queues(int data)
        {
            Node newNode = new Node(data);

            head = newNode;
            tail = newNode;
            size = 1;
        }

        public void Enqueue(int data)
        {
            Node newNode = new Node(data);

            if (size == 0)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.next = newNode;
                tail = newNode;
            }
            size++;
        }

        public void PrintAll()
        {
            Node temp = head;

            while(temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }

        public void PrintHead()
        {
            Console.WriteLine("The head of queues is : " + head.data);
        }

        public void PrintTail()
        {
            Console.WriteLine("The tail of queues is : " + tail.data);
        }

        public void PrintSize()
        {
            Console.WriteLine("The size of queues is : " + size);
        }

        public Node Dequeue()
        {
            if (size == 0)
                return null;

            Node temp = head;

            if (size == 1)
            {
                head = null;
                tail = null;
            }
            else
            {   
                head = head.next;
                temp.next = null;
            }
            size--;
            return temp;
        }

        public int Peek()
        {
            if (size != 0)
                return head.data;
            else
                return -1;   
        }
        
        public bool isEmpty()
        {
            return size == 0;   
        }
    }
}
