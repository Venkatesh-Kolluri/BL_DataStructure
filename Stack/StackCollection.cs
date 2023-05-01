using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Stack
{
    internal class StackCollection<T>
    {
        T[] obj;
        int capacity;
        int top = -1;
        public StackCollection(int capacity=4)
        {
            this.capacity = capacity;
            obj = new T[capacity];
        }

        public bool Push(T i)
        {
            if (top == capacity-1)
            {
                Console.WriteLine("The stack is full");
                return false;
            }
            obj[++top] = i;
            return true;
        }
        public T Peek()
        {
            if(top == -1)
            {
                Console.WriteLine("No value present in the stack");
                return default;
            }
          
            return obj[top];
        }

        public int Size()
        {           
            return (top + 1);
        }

        public void Print()
        { 
            for(int i = 0; i < obj.Length; i++)
            {
                Console.WriteLine(obj[i]);
            }         
        }
        public bool IsEmpty()
        {
            if (top == -1)
            {
                return true;
            }
            return false;
        }
        public T Pop()
        {
            if(top == -1)
            {
                Console.WriteLine("Stack is UnderFlow");
                return default;
            }

            return obj[top--];
        }      
      

    }
}
