using System.ComponentModel;
using System.Linq.Expressions;
using System.Xml;

namespace App_16_Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //TODO: Create a delegate predicate to find prime numbers
            /*
            List <int>  numberList = new ();
            numberList.AddRange(new int[] {1,2,3,4,5,5,6,2,7,8,9,9,1,4,34,534,635,23,2 });
            //Declaramos delegado predicado

            Predicate<int> DelegadoPredicado = new(IsEven);

            List<int> evenList = new ();
            evenList = numberList.FindAll(DelegadoPredicado);

            foreach (int element in evenList)
                Console.WriteLine(element);
            */

            Person person;
            bool continueLoop;
            List<Person> PersonList = new();
            do
            {
                person = new Person();
                Console.WriteLine("(Do not type to exit insertion)");
                Console.Write("Type a name: ");
                person.Name = Console.ReadLine();
                Console.Write("Type an age: ");
                try
                {
                    person.Age = int.Parse(Console.ReadLine());
                }
                catch(Exception e)
                {
                    person.Age = 0;
                }

                if(person.Age == 0 || person.Name == "")
                {
                    Console.WriteLine("Exit insertion");
                    continueLoop = false;
                }
                else
                {
                    PersonList.Add(person);
                    continueLoop = true;
                }

                Console.Clear();
            } while (continueLoop);

            foreach (Person element in PersonList)
                Console.WriteLine("name: {0}, Age: {1}", element.Name, element.Age);
            Predicate<Person> newPredicate = new(IsAdult);
            bool exist = PersonList.Exists(newPredicate);

            if (exist) Console.WriteLine("There are adults in the list");
            else Console.WriteLine("There are no adults in the list.");
        }

        static bool IsAdult(Person person)
        {
            if (person.Age >= 18)
                return true;
            else
                return false;
        }


        class Person
        { 
            private string nombre;
            private int edad;
            public string Name { get => nombre; set => nombre = value; }
            public int Age { get => edad; set => edad = value; }
        }

        

    }
}