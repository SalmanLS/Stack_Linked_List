using System;

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
            top = null;
        }
        bool empty()
        {
            if (top == null)
                return (true);
            else
                return (false);
        }
        public void push(int element)
        {
            Node fresh; //fresh is the new node/ new data
            fresh = new Node(element, null);

            fresh.next = top;
            top = fresh;
            Console.WriteLine("\n" + element + "pushed");
        }

        public void pop()
        {
            Console.WriteLine("\n The popped element is: " + top.info);
            top = top.next;//make top point to the next node is sequence
        }
        
        public void dispay()
        {
            Node tmp;
            if (empty())
                Console.WriteLine("\n Stack is empty");
            else
            {
                for(tmp = top; tmp != null; tmp = tmp.next)
                {
                    Console.WriteLine(tmp.info);
                }
            }
        }
    }
}