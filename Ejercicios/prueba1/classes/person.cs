using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba1.classes
{
    internal class Person
    {
        public string name { get; set; }
        public int age { get; set; }
      
        public void Introduce(string name, int age)
        {
            Console.WriteLine($"Mi nombres es {name}, tengo {age} años");
            if (age > 12 && age < 21)
            {
                Console.WriteLine("Eres un adolescente");
            }
            else
            {
                if (age < 12) { Console.WriteLine("eres un niño "); }
                else { Console.WriteLine("Eres un adulto"); }
            }
        }
    }
}   