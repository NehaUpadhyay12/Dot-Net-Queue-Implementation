using System;
using System.Collections;

namespace QueueOperations
{
    public class QueueUsingStack
    {
        Stack s1 = new Stack();
        Stack s2 = new Stack();

        public static void Runner()
        {
            QueueUsingStack obj = new QueueUsingStack();
            obj.Dequeue();
            obj.Enqueue(10);
            obj.Enqueue(20);
            obj.Enqueue(30);
            obj.Enqueue(40);
            obj.Dequeue();
            obj.Dequeue();
            obj.Enqueue(50);
            obj.Enqueue(60);
            obj.Enqueue(70);
            obj.Dequeue();
            obj.Dequeue();

        }
        public void Enqueue(int data)
        {
            s1.Push(data);
            Console.WriteLine($"Element entered in queue is {data}");
        }

        public void Dequeue()
        {
            if (s1.Count == 0 && s2.Count == 0)
                Console.WriteLine("Queue is empty");
            else
            {
                if (s2.Count == 0)
                {
                    while (s1.Count != 0)
                    {
                        s2.Push(s1.Pop());
                    }

                }
                int temp = (int)s2.Pop();
                Console.WriteLine($"Element removed from queue is {temp}");
            }
        }
    }
}
