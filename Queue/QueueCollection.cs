using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Queue
{
    class QueueCollection<T>
    {
        int capacity;
        T[] obj;
        int front = -1, rear = -1;
        public QueueCollection(int capacity=4)
        {
            this.capacity = capacity;
            obj = new T[capacity];
        }
        public bool Enqueue(T data)
        {
            if (rear == capacity - 1)
            {
                Console.WriteLine("Queue is Full");
                return false;
            }
            else if(rear==-1)
            {
                front++;

            }
            obj[++rear] = data;
            return true;
        }
        public void Print()
        {
            for(int i=0; i<= rear; i++)
            {
                Console.WriteLine(obj[i]);
            }
        }      
        public T Dequeue()
        {
            if(rear == - 1)
            {
                Console.WriteLine("Queue is Empty");
                return default;

            }
            T ob=obj[front];
            
            for (int i = front; i <= rear-1; i++)
            {
                obj[i] = obj[i+1];
                
            }
            rear=rear - 1;
            return ob;

        }
        public T Peek()
        {
            T ob = obj[0];
            return ob;             
        }
        public bool Contains(T data)
        {
            if(front == -1)
            {
                Console.WriteLine("Queue is Empty");
                return false;
            }
            for(int i=front; i<=rear; i++)
            {
                if (obj[i].Equals( data))
                {
                    Console.WriteLine(" the queue contains: "+data);
                    return true;              
                }
            }
            return false;           
        } 
        public bool IsEmpty()
        {
            if(rear == -1)
            {
                return true;
            }
            return false;
        }
        public int Size()
        {
            if(rear == -1)
            {
                return 0;
            }
            else
            {
                return rear+1;
            }
        }
        public override string ToString()
        {
            String s = "";
            for (int i = front; i <= rear && front != -1; i++)
            {
                s = s + obj[i] + " ";

            }
            return s;
        }
    }
}





