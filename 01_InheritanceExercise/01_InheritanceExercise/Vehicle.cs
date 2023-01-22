using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_InheritanceExercise
{
    class Vehicle
    {
        public void StartEngine() => Console.WriteLine("Engine starting protocol...");

        public void StopEngine() => Console.WriteLine("Engine stopping now.");

        public virtual void Drive() => Console.WriteLine("Starting protocol...");

    }
}
