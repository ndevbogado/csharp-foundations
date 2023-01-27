namespace App_15_Collection_Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Stack<int> stack = new Stack<int>();

            int element;
            do
            {
                Console.Write("Type data into the stack (Type '0' to exit insertion): ");
                element = int.Parse(Console.ReadLine());  
                if (element !=0)
                    stack.Push(element);
            } while (element != 0);

            foreach(int data in stack)
                Console.WriteLine(data);
            */
            Dictionary<string, string> dictionary = new();

            string key;
            string value;
            do
            {
                Console.Clear();
                Console.WriteLine("Type '0' in key and value input to exit insertion: ");
                Console.Write("Type a Key: ");
                key = Console.ReadLine();
                Console.Write($"Type a value for '{key}': ");
                value = Console.ReadLine();
                if (key != "0" || value != "0")
                    dictionary.Add(key, value);
            } while (key != "0" || value != "0");

            Console.Clear();
            foreach (KeyValuePair<string, string> kvp in dictionary)
                Console.WriteLine($"'{kvp.Key}' : '{kvp.Value}'");


        }
    }
}