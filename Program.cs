namespace Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queues queues = new Queues();
            queues.Enqueue(5);
            queues.Enqueue(12);
            queues.Enqueue(7);
            
            queues.PrintAll();
            queues.PrintHead();
            queues.PrintTail();
            queues.PrintSize();

            Console.WriteLine("***********");

            Node deleteNode = queues.Dequeue();
            queues.PrintAll();
            queues.PrintHead();
            queues.PrintTail();
            queues.PrintSize();
            Console.WriteLine(deleteNode.data);
        }
    }
}
