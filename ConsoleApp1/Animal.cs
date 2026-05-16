using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Animal
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public Animal(int age, string name)
        {
            this.Age = age;
            this.Name = name;
        }

        public override string ToString()
        {
            return ($"Animal {Name}, Age: {Age}");
        }

    }
}




