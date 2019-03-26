using System;
namespace QueueOperations
{
    public class QueueUsingArray
    {
        int front, rear, size;
        object[] arr;
        bool isEmpty = false, isFull = false;
        public QueueUsingArray(int size)
        {
            this.size = size;
            front = -1;
            rear = 0;
            arr = new object[size];
        }
        public static void Runner()
        {
            QueueUsingArray queue = new QueueUsingArray(5);

            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.TraverseQueue();
            Console.WriteLine("Item removed is: " + queue.Dequeue());
            queue.TraverseQueue();
            queue.Enqueue(40);
            queue.Enqueue(50);
            queue.Enqueue(60);
            queue.Enqueue(70);
            queue.TraverseQueue();
            Console.WriteLine("Item removed is: " + queue.Dequeue());
            Console.WriteLine("Item removed is: " + queue.Dequeue());
            queue.TraverseQueue();
            Console.WriteLine("Item removed is: " + queue.Dequeue());
            Console.WriteLine("Item removed is: " + queue.Dequeue());
            Console.WriteLine("Item removed is: " + queue.Dequeue());
            Console.WriteLine("Item removed is: " + queue.Dequeue());
            queue.TraverseQueue();
        }

        public void Enqueue(object element)
        {
            if (isFull)
                Console.WriteLine("Queue is full");
            else
            {
                if (front == -1)
                    front++;
                arr[rear] = element;
                rear = (rear + 1) % size;
                if (rear == front)
                    isFull = true;
                else
                    isFull = false;
            }

        }

        public object Dequeue()
        {
            object element = null;
            if (isEmpty)
                Console.WriteLine("Queue is empty");
            else
            {
                element = arr[front];
                front = (front + 1) % size;
                if (front == rear)
                    isEmpty = true;
                else
                    isEmpty = false;
            }

            return element;
        }

        public void TraverseQueue()
        {
            Console.WriteLine("The queue is:");
            if (!isEmpty)
            {
                int i = front;
                do
                {
                    Console.Write(arr[i] + ", ");
                    i = (i + 1) % size;
                } while (i != rear);
            }
            Console.WriteLine();
        }
    }
}
