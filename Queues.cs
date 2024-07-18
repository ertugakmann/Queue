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
    }
}
