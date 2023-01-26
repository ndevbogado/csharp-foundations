using System.Runtime.Serialization.Formatters;

namespace App_13_Collections_LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new();

            Console.Write("Type a number to add to the first index in the linked list: ");
            list.AddFirst(int.Parse(Console.ReadLine()));

            foreach (int element in new[] {1,2,3,4,5,6,7,8,9,0 })
            {
                list.AddFirst(element);
            }

            while (list.Contains(6))
                list.Remove(6);


            Console.Clear();
            Console.WriteLine("Displaying LinkedList: ");

            for (LinkedListNode<int> nodo = list.First; nodo != null; nodo = nodo.Next)
                Console.WriteLine(nodo.Value);
            /*
            foreach (int element in list)
                Console.WriteLine(element);
            */
        }
    }
}