namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StackCollection<int> stackCollection = new StackCollection<int>();
            stackCollection.Push(100);
            stackCollection.Push(200);
            stackCollection.Push(300);
            stackCollection.Push(400);
            //  stackCollection.Push(500);
            stackCollection.Pop();

            stackCollection.Push(500);
            stackCollection.Print();
            Console.WriteLine("The peek value is: " + stackCollection.Peek());
            Console.WriteLine("The Size Of Stack is: " + stackCollection.Size());
            stackCollection.Pop();

            stackCollection.Push(9);

            stackCollection.Pop();
            stackCollection.Print();
            stackCollection.Pop();
            Console.WriteLine("Is Stack Empty: " + stackCollection.IsEmpty());
        }
    }
}