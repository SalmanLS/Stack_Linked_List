﻿using System;

namespace StackUsingSingleLinkList
{
    class Node
    {
        public int info;
        public Node next;
        public Node(int i, Node n)
        {
            info = i; //data dari stack
            next = n;
        }
    }
    class Stack
    {
        Node top;
        public Stack()
        {
            Node top;
        }
    }
}