using System.ComponentModel;

namespace App_16_Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //TODO: Create a delegate predicate to find prime numbers
            List <int>  numberList = new ();
            numberList.AddRange(new int[] {1,2,3,4,5,5,6,2,7,8,9,9,1,4,34,534,635,23,2 });
            //Declaramos delegado predicado

            Predicate<int> DelegadoPredicado = new(IsEven);

            List<int> evenList = new ();
            evenList = numberList.FindAll(DelegadoPredicado);

            foreach (int element in evenList)
                Console.WriteLine(element);
        }

        static bool IsEven(int number)
        {
            if (number % 2 == 0)
                return true;
            else
                return false;
        }

        

    }
}