namespace App_14_Collections_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> newQueue = new();
            // rellenando Queue

            int element;
            do
            {
                Console.WriteLine("Type data to queue (Type '0' to exit enqueuement): ");
                element = int.Parse(Console.ReadLine());
                if (element != 0)
                    newQueue.Enqueue(element);
                Console.Clear();
            } while (element != 0);

            foreach(int data in newQueue)
                Console.WriteLine(data);

            for (int i = newQueue.Count; i > 0; i--)
                newQueue.Dequeue();

            Console.WriteLine("Dispalying Dequeue: ");
            foreach(int data in newQueue)
                Console.WriteLine(data);
        }
    }
}