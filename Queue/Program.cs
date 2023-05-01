namespace Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {

            QueueCollection<string> q = new QueueCollection<string>();
            q.Enqueue("Welcome");
            q.Enqueue("World");
            q.Enqueue("Thank you");
            q.Enqueue("Good Morning");
            q.Print();

            Console.WriteLine("The Dequeue element is: " + q.Dequeue());     //removes the first element  
            Console.WriteLine("The Dequeue Element is " + q.Dequeue());
            q.Enqueue("Good Bye");
            q.Print();

            Console.WriteLine("The peek element in Sting is: " + q.Peek());       //gives the first element present in the queue
            Console.WriteLine("==============================================================================================");

            QueueCollection<int> que = new QueueCollection<int>();
            que.Enqueue(10);
            que.Enqueue(20);
            que.Enqueue(30);
            que.Enqueue(40);

            que.Print();

            Console.WriteLine(que.Contains(20));

            que.Dequeue();
            que.Dequeue();

            Console.WriteLine("The size of the queue is: " + que.Size());
            Console.WriteLine("The peek value is: " + que.Peek());
            Console.WriteLine("Queue in string: " + que.ToString());
            que.Dequeue();

            Console.WriteLine("The dequeue element is: " + que.Dequeue());

            que.Dequeue();
            que.Print();
            Console.WriteLine("Is the value 30 present in the queue: " + que.Contains(30));
        }
    }
}