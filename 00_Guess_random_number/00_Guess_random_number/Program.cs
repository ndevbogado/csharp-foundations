using System.Linq.Expressions;

namespace _00_Guess_random_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random(); // Creates a new object from Random Class.

            int randomNumber = random.Next(0,100); // Generates a random Number between min (0) and max (100).

            int attempt = 0;
            int answer = typeNumber(attempt);

            while (answer != randomNumber)
            {
                if (answer < randomNumber)
                    Console.WriteLine($"{answer} is less than the number.");
                else if (answer > randomNumber)
                    Console.WriteLine($"{answer} is more than the number.");

                attempt++;
                answer = typeNumber(attempt);
            }
            if (attempt == 0)
                Console.WriteLine("You have guessed the number without any attempts!");
            else if (attempt == 1)
                Console.WriteLine("You have guessed the number in 1 attempt!");
            else
                Console.WriteLine($"You have guessed the number in {attempt} attempts");
        }

        static int typeNumber(int attempt)
        {
            int number;
            do
            {
                Console.Write($"Please type a number between the required range -- (Attempt {attempt}): ");
                try
                {
                    number = int.Parse(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Invalid interger input!");
                    number = -1;
                }
                catch(StackOverflowException e)
                {
                    Console.WriteLine("Invalid integer input!");
                    number = -1;
                }
            } while (number < 0 || number > 100);
            return number;
        }

    }
}