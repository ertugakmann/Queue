﻿using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Node
    {
        private int data { get; set; }
        public Node next { get; set; }

        public Node(int data)
        {
            this.data = data;
            next = null;
        }
    }
}
