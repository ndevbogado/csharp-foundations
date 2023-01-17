using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_05_POO
{
    internal class Punto
    {
        public Punto() 
        {
            Console.WriteLine("Este es el Constructor por defecto.");        
        }
        public Punto(int x, int y)
        {
            Console.WriteLine($"(x = {x}; y = {y})");
        }
    }
}
