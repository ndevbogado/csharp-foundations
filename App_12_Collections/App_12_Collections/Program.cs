using System.ComponentModel;
using System.Linq.Expressions;

namespace App_12_Collections
{
    internal class Program
    {
        static void Main(string[] args)

        {
            List<int> numbers = new(); // Declarar una nueva Lista

            Console.Write("Type '0' for known length or '1' to add until satisfied: ");
            int decision = int.Parse(Console.ReadLine());
            switch (decision)
            {
                case 0:
                    Func0(numbers);
                    break;
                case 1:
                    Func1(numbers);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Good Bye!");
                    break;
                
            }

            Console.Clear();
            Console.WriteLine("Dispalying List: ");
            numbers.ForEach(name => Console.WriteLine(name));
           
        }
        
        static void Func1 (List<int> numbers)
        {
            int elem;
            do
            {
                Console.Write("Type an element to add (type '0' to exit): ");
                elem = int.Parse(Console.ReadLine());
                numbers.Add(elem);
                Console.Clear();
            } while (elem != 0);

            numbers.RemoveAt(numbers.Count() - 1);
        }

        static void Func0 (List<int> numbers)
        {
            Console.Write("Type the length of your list: ");
            int length = int.Parse(Console.ReadLine());
            for (int i = 0; i < length; i++)
            {
                Console.Clear();
                Console.WriteLine($"Type data for position {i}");
                numbers.Add(int.Parse(Console.ReadLine()));
            }

        }
    }
}