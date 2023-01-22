using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_InheritanceExercise
{
    class Car : Vehicle
    {
        public override void Drive() => Console.WriteLine("Runnig...");
    }

}
